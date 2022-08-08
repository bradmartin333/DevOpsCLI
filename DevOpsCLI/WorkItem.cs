using System;
using System.Text.RegularExpressions;

namespace DevOpsCLI
{
    public class WorkItem
    {
        private readonly Regex TITLE_REGEX = new Regex("(?<=\"System.Title\": \")[^\"]*");
        public string Title { get; set; }
        private readonly Regex AREAID_REGEX = new Regex($"(?<=\"System.AreaId\": )[^,]*");
        public string AreaID { get; set; }
        private readonly Regex ID_REGEX = new Regex($"(?<=\"System.Id\": )[^,]*");
        public string ID { get; set; }
        private readonly Regex ITERATIONPATH_REGEX = new Regex($"(?<=\"System.IterationPath\": )[^,]*");
        public string IterationPath { get; set; }

        public WorkItem(string info)
        {
            try
            {
                Title = TITLE_REGEX.Matches(info)[0].ToString();
                AreaID = AREAID_REGEX.Matches(info)[0].ToString();
                ID = ID_REGEX.Matches(info)[0].ToString();
                IterationPath = ITERATIONPATH_REGEX.Matches(info)[0].ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("\nUnable to initialize work item");
            }
        }

        public bool IsValid() => !(string.IsNullOrEmpty(Title) && string.IsNullOrEmpty(AreaID) && string.IsNullOrEmpty(ID) && string.IsNullOrEmpty(IterationPath));
    }
}
