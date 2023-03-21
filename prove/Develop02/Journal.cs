using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using static System.Console;

namespace JournalApp
{
    class Journal
    {
        private string JournalFile = "MyJournal.txt";
        public void Run()
        {
            DisplayIntro();
            ShowMenu();
            CreateFile();
            DisplayFile();

            DisplayOutro();
        }

        private void DisplayIntro() 
        {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                Clear();
            
                
        }
        private void ShowMenu()
        {
            WriteLine("Journal App");
                WriteLine("What would you like to do?");
                WriteLine("1. Write In a Journal");
                WriteLine("2. Display Journal File");
                WriteLine("3. Quit");
                Console.WriteLine("Type the number of your choice: ");
                string input = Console.ReadLine();

                

                if (int.TryParse(input, out int number))
                {
                    while (number == 0)
                    {
                        ShowMenu();
                        if (number == 2)
                        {
                            DisplayFile();
                        }
                        if (number == 1)
                        {
                            CreateFile();
                        }

                    }
                    
                }

        }

        private void CreateFile()
        {
            // WriteLine($"Does file exist? {System.IO.File.Exists("MyJournal.txt")}");

            if (!File.Exists(JournalFile))
            {
                File.CreateText(JournalFile);
            }
        }
        private void DisplayOutro()
        {
            WriteLine("\nThank you for using the Journal!");
            WriteLine("Goodbye!");
            ReadKey(true);
        }

        private void WaitForKey()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            // WriteLine("\nPress any key...");
            ReadKey(true);
        }

        private void DisplayFile()
        {
            string journalText = File.ReadAllText(JournalFile);
            WriteLine("++++++++++  Journal +++++++++:");
            WriteLine(journalText);
            WriteLine("=========END=========");
            WaitForKey();
        }

        

    }
}
// References
// https://www.youtube.com/watch?v=sWfe80Fj9Pg&t=2275s
