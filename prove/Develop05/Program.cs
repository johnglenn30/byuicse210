using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity:");
            Console.WriteLine("2. Reflection Activity:");
            Console.WriteLine("3. Listing Activity:");
            Console.WriteLine("4. Quit:");
            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                        Goals.Run(new CreateGoals());
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
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

        
            }

        }
    }
}

