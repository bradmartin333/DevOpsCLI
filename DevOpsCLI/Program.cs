using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOpsCLI
{
    internal class Program
    {
        private static readonly System.Timers.Timer Timer = new System.Timers.Timer(5000); // Give user 5 second delay to cancel
        private static readonly List<string> NewIDs = new List<string>();
        private static CancellationTokenSource TokenSource;

        static void Main(string[] args)
        {
            Timer.Elapsed += Timer_Elapsed;

            Console.WriteLine("Software DevOps Generator v0.1\n");
            Console.WriteLine("Fetching names...");
            //Azure.GetNames();

            while (true)
            {
                Console.WriteLine("Awaiting user input...");
                TokenSource = new CancellationTokenSource();

                // Get these from the dialog
                string userName, userStoryTitle, sprintNum;
                string[] taskTitles;

                //using (UserEntry userEntry = new UserEntry(Azure.Names.ToArray()))
                using (UserEntry userEntry = new UserEntry(new string[] { "billy" }))
                {
                    DialogResult result = userEntry.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        userName = userEntry.UserName;
                        userStoryTitle = userEntry.UserStoryTitle;
                        sprintNum = userEntry.SprintNum;
                        taskTitles = userEntry.TaskTitles;
                    }
                    else
                        return;
                }

                Console.WriteLine($"\nCreating a user story for {userName} named {userStoryTitle}");
                Console.WriteLine($"for Sprint {sprintNum} in the Sofware project");
                Console.WriteLine($"with 5 custom titled child tasks");
                Console.WriteLine($"\nPress any key to cancel");

                Timer.Start();
                ConsoleKeyInfo end = Console.ReadKey();
                TokenSource.Cancel();
                Timer.Stop();
                Console.WriteLine("\n");

                if (NewIDs.Count > 0) Console.WriteLine($"{NewIDs.Count} new IDs have been created.");
                Console.WriteLine("Press 'r' to run again");
                Console.WriteLine("Press 'd' to delete any newly created IDs and run again");
                Console.WriteLine("Press any other key to quit");

                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine("\n");
                switch (input.KeyChar)
                {
                    case 'r':
                        break;
                    case 'd':
                        Console.WriteLine("Press d again to confirm deletion");
                        ConsoleKeyInfo confirm = Console.ReadKey();
                        Console.WriteLine("\n");
                        if (confirm.KeyChar == 'd')
                            Console.WriteLine($"Deleting {NewIDs.Count} items...");
                        break;
                    default:
                        return;
                }
            }
        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("\n--- Task Started ---\n");
            NewIDs.Clear();
            Timer.Stop();

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

            CancellationToken token = TokenSource.Token;
            Task Task = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    if (token.IsCancellationRequested) return;
                    Console.WriteLine(i);
                    NewIDs.Add(i.ToString());
                    Thread.SpinWait(10000000);
                }
                Console.WriteLine("\nTask Complete\nPress any key to continue");
            },
            token);
        }
    }
}
