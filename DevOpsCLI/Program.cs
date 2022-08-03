using System;
using System.Diagnostics;
using System.Linq;

namespace DevOpsCLI
{
    internal class Program
    {
        private readonly static string[] WorkItemTypes = new string[] { "User Story", "Task" };

        static void Main(string[] args)
        {
            string userStoryID = CreateWorkItem("Test Story", WorkItemTypes[0], "Hardware\\Max", "Hardware");
            if (string.IsNullOrEmpty(userStoryID))
                Console.WriteLine("Invalid Entry - Ensure that the desired Sprint exists and try again");
            else
            {
                Console.WriteLine($"Created User Story {userStoryID}");
                for (int i = 1; i <= 5; i++)
                {
                    string taskID = CreateWorkItem($"Test Task {i}", WorkItemTypes[1], "Hardware\\Max", "Hardware");
                    AssignParent(taskID, userStoryID);
                    Console.WriteLine($"Created Task {taskID}");
                }
            }

            Console.WriteLine("Done - press any key to exit");
            Console.ReadKey();
        }

        private static string CreateWorkItem(string title, string type, string sprintNum, string project = "Software")
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = $"az boards work-item create --title \\\"{title}\\\" --type \\\"{type}\\\" --area \\\"{sprintNum}\\\" --project \\\"{project}\\\" --reason \\\"New\\\" --output tsv",
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
                string line = output.ReadLine();
                if (string.IsNullOrEmpty(line)) return null;
                return line.Split('/').Last();
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static void AssignParent(string childID, string parentID)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = $"az boards work-item relation add --id {childID} --relation-type parent --target-id {parentID}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = @"C:\",
                }
            };

            proc.Start();
            proc.WaitForExit();
        }
    }
}
