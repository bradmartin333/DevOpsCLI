using System;
using System.Collections.Generic;
using System.Linq;

namespace DevOpsCLI
{
    internal class Program
    {
        //public static readonly string Project = "Hardware"; // For debugging
        public static readonly string Project = "Software";

        [STAThread]
        static void Main(string[] args)
        {
            PrintHeader();

            while (true)
            {
                Console.WriteLine("Enter a User Story ID to create standard child tasks");
                Console.WriteLine("(Right click to paste, enter nothing to see story point plot)");
                Console.Write("\n> ");
                string entry = Console.ReadLine();
                if (string.IsNullOrEmpty(entry))
                    StoryPointPlot();
                else
                {

                }
                Console.WriteLine(entry);
            }
        }

        private static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ____              ___             ____ _     ___ ");
            Console.WriteLine("|  _ \\  _____   __/ _ \\ _ __  ___ / ___| |   |_ _|");
            Console.WriteLine("| | | |/ _ \\ \\ / / | | | '_ \\/ __| |   | |    | | ");
            Console.WriteLine("| |_| |  __/\\ V /| |_| | |_) \\__ \\ |___| |___ | | ");
            Console.WriteLine("|____/ \\___| \\_/  \\___/| .__/|___/\\____|_____|___|");
            Console.Write("                       |_|                    ");
            Console.ResetColor();
            Console.WriteLine("v0.2\n");
        }

        private static void StoryPointPlot()
        {
            Console.WriteLine("Fetching story point data...\n");
            Azure.StoryPoints();
            int padSize = Azure.StoryPointDict.Select(x => x.Key.Length).Max() + 2;
            bool toggleColor = false;
            foreach (KeyValuePair<string, int> item in Azure.StoryPointDict)
            {
                if (toggleColor)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else
                    Console.ResetColor();
                Console.Write($"{item.Key.PadRight(padSize)}\t{item.Value,-5}");
                for (int i = 0; i < item.Value; i++)
                    Console.Write("*");
                Console.WriteLine();
                toggleColor = !toggleColor;
            }
            Console.ResetColor();
        }
    }
}
