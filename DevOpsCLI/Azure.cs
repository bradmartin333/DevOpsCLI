using System;
using System.Diagnostics;
using System.Linq;

namespace DevOpsCLI
{
    public class Azure
    {
        public static string WorkItemData { get; set; }

        public static WorkItem GetWorkItem(string id)
        {
            WorkItemData = string.Empty;

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = $"az boards work-item show --id {id}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = @"C:\",
                }
            };

            proc.OutputDataReceived += WorkItemDataReceived; // Async gather lines
            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();

            return new WorkItem(WorkItemData);
        }

        private static void WorkItemDataReceived(object sender, DataReceivedEventArgs e)
        {
            WorkItemData += $"{e.Data}\n";
        }

        public static string CreateWorkItem(string title, string assignee, string area, string type = "Task", string storyPoints = null)
        {
            string arg = $"az boards work-item create " +
                         $"--title \\\"{title}\\\" " +
                         $"--project \\\"{Program.Project}\\\" " +
                         $"--reason \\\"New\\\" " +
                         $"--fields \\\"Area ID={area}\\\" " +
                         $"--type \\\"{type}\\\" " +
                         $"{(string.IsNullOrEmpty(assignee) ? "" : $"--assigned-to \\\"{assignee}\\\" ")}" +
                         $"{(string.IsNullOrEmpty(storyPoints) ? "" : $"\\\"Story Points={storyPoints}\\\" ")}" +
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
    }
}
