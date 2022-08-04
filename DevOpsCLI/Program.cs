using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOpsCLI
{
    internal class Program
    {
        //public static readonly string Project = "Hardware"; // For debugging
        public static readonly string Project = "Software";
        private static readonly System.Timers.Timer Timer = new System.Timers.Timer(5000); // Give user 5 second delay to cancel
        private static readonly List<string> NewIDs = new List<string>();
        private static CancellationTokenSource TokenSource;
        private static string UserName, UserStoryTitle, StoryPoints, Area;
        private static string[] TaskTitles;

        [STAThread]
        static void Main(string[] args)
        {
            Timer.Elapsed += Timer_Elapsed;

            Console.WriteLine("Software DevOps Generator v0.1\n");
            Console.WriteLine("Fetching names...");
            Azure.GetNames();
            Console.WriteLine("Fetching project areas...");
            Azure.GetAreas();

            while (true)
            {
                Console.WriteLine("Awaiting user input...");
                TokenSource = new CancellationTokenSource();

                bool run = true;
                using (UserEntry userEntry = new UserEntry())
                {
                    DialogResult result = userEntry.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        UserName = userEntry.UserName;
                        UserStoryTitle = userEntry.UserStoryTitle;
                        StoryPoints = userEntry.StoryPoints;
                        Area = Azure.AreaIDs[Azure.Areas.IndexOf(userEntry.Area)];
                        TaskTitles = userEntry.TaskTitles.ToList().Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    }
                    else
                        run = false;
                }

                if (run)
                {
                    Console.WriteLine($"\nCreating a user story for {UserName} named {UserStoryTitle}");
                    Console.WriteLine($"in the {Project} project{(TaskTitles.Length > 0 ? $" with {TaskTitles.Length} custom titled child tasks" : "")}");
                    Console.WriteLine($"\nPress any key to cancel");
                    Timer.Start();
                }
                else
                    Console.WriteLine("\nNo task run\nPress any key to continue");
                
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
                        {
                            Console.WriteLine($"Deleting {NewIDs.Count} items...");
                            int deleteCount = 0;
                            foreach (string id in NewIDs)
                                deleteCount += Azure.DeleteWorkItem(id, Project);
                            Console.WriteLine($"Deleted {deleteCount} items\n");
                        }
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

            CancellationToken token = TokenSource.Token;

            Task Task = Task.Factory.StartNew(() =>
            {
                if (token.IsCancellationRequested) return;
                string userStoryID = Azure.CreateWorkItem(UserName, UserStoryTitle, "User Story", Area, StoryPoints);
                Console.WriteLine($"Created User Story {userStoryID}");
                if (string.IsNullOrEmpty(userStoryID))
                {
                    Console.WriteLine("Failed to create user story\nCancelling...\nPress any key to continue");
                    return;
                }
                NewIDs.Add(userStoryID);

                for (int i = 0; i < TaskTitles.Length; i++)
                {
                    if (token.IsCancellationRequested) return;
                    string taskID = Azure.CreateWorkItem(UserName, TaskTitles[i], "Task", Area);
                    if (string.IsNullOrEmpty(taskID))
                    {
                        Console.WriteLine("Failed to create user story\nCancelling...");
                        return;
                    }
                    NewIDs.Add(taskID);
                    Console.WriteLine($"Created Task {taskID}");
                    if (token.IsCancellationRequested) return;
                    Azure.AssignParent(taskID, userStoryID);
                }

                Console.WriteLine("\nTask Complete\nPress any key to continue");
            },
            token);

            // Dummy task for debugging
            //Task Task = Task.Factory.StartNew(() =>
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        if (token.IsCancellationRequested) return;
            //        Console.WriteLine(i);
            //        NewIDs.Add(i.ToString());
            //        Thread.SpinWait(10000000);
            //    }
            //    Console.WriteLine("\nTask Complete\nPress any key to continue");
            //},
            //token);
        }
    }
}
