﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DevOpsCLI
{
    public class Azure
    {
        public static readonly List<string> Names = new List<string>();
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

        public static int DeletaWorkItem(string id, string project)
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
            if (e.Data != null && e.Data.Contains("displayName"))
            {
                string name = e.Data.Split('\"')[3]; // Assumes consistent output
                if (!Names.Contains(name)) Names.Add(name); // One way to have no duplicates
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
    }
}
