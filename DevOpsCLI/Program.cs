using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DevOpsCLI
{
    internal class Program
    {
        private static readonly List<string> Names = new List<string>(); // Hardcoded to obtain the top 1000
        private static readonly System.Timers.Timer Timer = new System.Timers.Timer(5000); // Give user 5 second delay to cancel

        static void Main(string[] args)
        {
            Console.WriteLine("Software DevOps Generator v0.1\n");
            Console.WriteLine("Fetching names...");
            GetNames();
            Console.WriteLine("Awaiting user input...");

            string userName, userStoryTitle, sprintNum; // Get these from the dialog
            using (UserEntry userEntry = new UserEntry(Names.ToArray()))
            {
                DialogResult result = userEntry.ShowDialog();
                if (result == DialogResult.OK)
                {
                    userName = userEntry.UserName;
                    userStoryTitle = userEntry.UserStoryTitle;
                    sprintNum = userEntry.SprintNum;
                }
                else
                    return;
            }

            Console.WriteLine($"\nCreating a user story for {userName}");
            Console.WriteLine($"named {userStoryTitle}");
            Console.WriteLine($"for Sprint {sprintNum} in the Sofware project");
            Console.WriteLine($"with 5 custom titled child tasks.");
            Console.WriteLine($"\nPress any key to cancel.\n");
            Timer.Elapsed += Timer_Elapsed;
            Timer.Start();
            ConsoleKeyInfo i = Console.ReadKey(); // Will always close the window, even if the automation process is running
        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //private readonly static string[] WorkItemTypes = new string[] { "User Story", "Task" };
            //string userStoryID = CreateWorkItem("Test Story", WorkItemTypes[0], "Hardware\\Max", "Hardware");
            //if (string.IsNullOrEmpty(userStoryID))
            //    Console.WriteLine("Invalid Entry - Ensure that the desired Sprint exists and try again");
            //else
            //{
            //    Console.WriteLine($"Created User Story {userStoryID}");
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        string taskID = CreateWorkItem($"Test Task {i}", WorkItemTypes[1], "Hardware\\Max", "Hardware");
            //        AssignParent(taskID, userStoryID);
            //        Console.WriteLine($"Created Task {taskID}");
            //    }
            //}

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.SpinWait(10000000);
            }

            Console.WriteLine("\nDone - press any key to exit\n");
            Timer.Stop();
        }

        private static string CreateWorkItem(string title, string type, string sprintNum, string project = "Software")
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                    Arguments = $"az boards work-item create --title \\\"{title}\\\" --type \\\"{type}\\\" --area \\\"Sprint {sprintNum}\\\" --project \\\"{project}\\\" --reason \\\"New\\\" --output tsv",
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

        private static void GetNames()
        {
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

            proc.OutputDataReceived += Proc_OutputDataReceived; // Async gather names
            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();
        }

        private static void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null && e.Data.Contains("displayName")) // Hardcoded keyword
            {
                string name = e.Data.Split('\"')[3]; // Assumes consistent output
                if (!Names.Contains(name)) Names.Add(name); // One way to have no duplicates
            }
        }
    }
}
