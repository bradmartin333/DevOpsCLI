﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DevOpsCLI
{
    public class Azure
    {
        public static readonly List<string> Names = new List<string>();
        public static readonly List<string> PrincipalNames = new List<string>();
        public static readonly List<string> Areas = new List<string>();
        public static readonly List<string> AreaIDs = new List<string>();

        public static string CreateWorkItem(string assignee, string title, string type, string area, string storyPoints = null)
        {
            string arg = $"az boards work-item create " +
                         $"--title \\\"{title}\\\" " +
                         $"--type \\\"{type}\\\" " +
                         $"--assigned-to \\\"{assignee}\\\" " +
                         $"--project \\\"{Program.Project}\\\" " +
                         $"--reason \\\"New\\\" " +
                         $"--fields \\\"Area ID={area}\\\" " +
                         $"{(string.IsNullOrEmpty(storyPoints) ? "" : $"\\\"Story Points={storyPoints}\\\"")} " +
                         $"--output tsv";

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = arg,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = @"C:\",
                }
            };

            try
            {
                proc.Start();
                proc.WaitForExit();
                System.IO.StreamReader output = proc.StandardOutput;
                string line = output.ReadLine(); // Only going to be one line since tsv output is specified
                if (string.IsNullOrEmpty(line)) return null;
                return line.Split('/').Last(); // ID of the work-item and assumes consistent output
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int DeleteWorkItem(string id, string project)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = $"az boards work-item delete --id {id} --project \\\"{project}\\\" -y --output tsv",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = @"C:\",
                }
            };

            try
            {
                proc.Start();
                proc.WaitForExit();
                System.IO.StreamReader output = proc.StandardOutput;
                string line = output.ReadLine(); // Only going to be one line since tsv output is specified
                if (string.IsNullOrEmpty(line)) return 0;
                return 1; // Success
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static void AssignParent(string childID, string parentID)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = $"az boards work-item relation add --id {childID} --relation-type parent --target-id {parentID}",
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    CreateNoWindow = true,
                    WorkingDirectory = @"C:\",
                }
            };

            proc.Start();
            proc.WaitForExit();
        }

        public static void GetNames()
        {
            // Hardcoded to obtain the top 1000
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = $"az devops user list --top 1000",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = @"C:\",
                }
            };

            proc.OutputDataReceived += NameDataReceived; // Async gather names
            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();
        }

        private static void NameDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                if (e.Data.Contains("displayName"))
                {
                    string name = e.Data.Split('\"')[3]; // Assumes consistent output
                    if (!Names.Contains(name)) Names.Add(name); // One way to have no duplicates
                }
                else if (e.Data.Contains("principalName"))
                {
                    string prinicpalName = e.Data.Split('\"')[3]; // Assumes consistent output
                    if (!PrincipalNames.Contains(prinicpalName)) PrincipalNames.Add(prinicpalName); // One way to have no duplicates
                }
            }
        }

        public static void GetAreas()
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = $"az boards area project list --project {Program.Project}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = @"C:\",
                }
            };

            proc.OutputDataReceived += AreaDataReceived; // Async gather areas
            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();
        }

        private static void AreaDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                if (e.Data.Contains("path"))
                {
                    string area = e.Data.Split('\"')[3]; // Assumes consistent output
                    if (!Areas.Contains(area)) Areas.Add(area); // One way to have no duplicates
                }
                else if (e.Data.Contains("\"id\""))
                {
                    string id = e.Data.Split(' ').Last().Replace(",", ""); // Assumes consistent output
                    if (!AreaIDs.Contains(id)) AreaIDs.Add(id); // One way to have no duplicates
                }
            }
        }

        #region Story Points

        public static Dictionary<string, int> StoryPointDict = new Dictionary<string, int>();

        public static void StoryPoints()
        {
            StoryPointDict = new Dictionary<string, int>();

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = $"az boards query --project \\\"{Program.Project}\\\" --wiql " +
                                $"\\\"SELECT[System.AssignedTo], [Microsoft.VSTS.Scheduling.StoryPoints] " +
                                $"FROM workitems WHERE[System.WorkItemType] <> '' AND[System.State] " +
                                $"IN('Active', 'New', 'Testing') AND[Microsoft.VSTS.Scheduling.StoryPoints] > 0 " +
                                $"AND([System.IterationPath] = @currentIteration('[Software]\\Perl <id:8b3cf2a1-eaf7-4bdf-b33c-21d28eb41ddc>') " +
                                $"OR[System.IterationPath] = @currentIteration('[Software]\\Vision <id:eb1a23de-64df-4f31-b667-09df055bb603>') " +
                                $"OR[System.IterationPath] = @currentIteration('[Software]\\InspectRx <id:737f5260-94be-4872-af6c-1ebb388510ed>')) " +
                                $"AND[System.AssignedTo] <> '' ORDER BY[System.AssignedTo]\\\" --output table",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = @"C:\",
                }
            };

            proc.OutputDataReceived += StoryPointReceived;
            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();
        }

        private static void StoryPointReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                if (e.Data.Contains(".com"))
                {
                    string[] data = e.Data.Split(' ');
                    string principalName = data.First();
                    string name = Names[PrincipalNames.IndexOf(principalName)];
                    int num = (int)double.Parse(data.Last());
                    if (StoryPointDict.ContainsKey(name))
                        StoryPointDict[name] += num;
                    else
                        StoryPointDict[name] = num;
                }
            }
        }

        #endregion
    }
}
