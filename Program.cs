﻿using Leetcode.Part_1._1_Arrays_Hashing;

class Program
{
    /// <summary>
    /// Main menu of the program
    /// </summary>
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(@" /$$       /$$$$$$$$ /$$$$$$$$ /$$$$$$$$ /$$$$$$   /$$$$$$  /$$$$$$$  /$$$$$$$$");
            Console.WriteLine(@"| $$      | $$_____/| $$_____/|__  $$__//$$__  $$ /$$__  $$| $$__  $$| $$_____/");
            Console.WriteLine(@"| $$      | $$      | $$         | $$  | $$  \__/| $$  \ $$| $$  \ $$| $$      ");
            Console.WriteLine(@"| $$      | $$$$$   | $$$$$      | $$  | $$      | $$  | $$| $$  | $$| $$$$$   ");
            Console.WriteLine(@"| $$      | $$__/   | $$__/      | $$  | $$      | $$  | $$| $$  | $$| $$__/   ");
            Console.WriteLine(@"| $$      | $$      | $$         | $$  | $$    $$| $$  | $$| $$  | $$| $$      ");
            Console.WriteLine(@"| $$$$$$$$| $$$$$$$$| $$$$$$$$   | $$  |  $$$$$$/|  $$$$$$/| $$$$$$$/| $$$$$$$$");
            Console.WriteLine(@"|________/|________/|________/   |__/   \______/  \______/ |_______/ |________/");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("| 1. Arrays & Hashing |");
            Console.WriteLine("| 0. Exit             |");
            Console.WriteLine("=======================");
            Console.Write("Select a Directory: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1": ArraysMenu(); break;
                case "0": Console.WriteLine("Exiting program..."); return;
                default: Console.WriteLine("Invalid choice, try again."); break;
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Menu for the Arrays & Hashing Section
    /// </summary>
    static void ArraysMenu()
    {
        ContainsDuplicates cd = new ContainsDuplicates();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Arrays & Hashing");
            Console.WriteLine("================");
            Console.WriteLine("1. Contains Duplicates");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Select a Program: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    int[] nums = { 1, 2, 3, 4, 2 };

                    cd.RunContainsDuplicate(nums);
                    break;
                case "0": return;
                default: Console.WriteLine("Invalid choice, try again."); break;
            }

            Console.WriteLine("\nPress any key to return to the Arrays menu...");
            Console.ReadKey();
        }
    }
}
