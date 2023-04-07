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
                        Activity.Run(new BreathingActivity());
                        break;
                    case "2":
                        Activity.Run(new ReflectionActivity());
                        break;
                    case "3":
                        Activity.Run(new ListingActivity());
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

        
            }

        }
    }
}