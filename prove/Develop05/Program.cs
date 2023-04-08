using System;

class Program
{
    static void Main(string[] args)
    {

        
        bool running = true;
        while (running)
        {
            
            Console.WriteLine($"You currently have points");
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Menu:");
            Console.WriteLine("1. Create New Goal:");
            Console.WriteLine("2. List Goals:");
            Console.WriteLine("3. Save Goals:");
            Console.WriteLine("4. Load Goals:");
            Console.WriteLine("5. Report Achieved Goal:");
            Console.WriteLine("6. Quit:");


            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                    case "1":
                        Goals.Run(new CreateGoals());
                        break;
                    case "2":
                        Goals.Run(new ListGoals());
                        break;
                    case "3":
                        Goals.Run(new SaveGoals());
                        break;
                    case "4":
                        Goals.Run(new LoadGoals());
                        break;
                    case "5":
                        Goals.Run(new ReportGoals());
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

        
            }

        }
    }
}

