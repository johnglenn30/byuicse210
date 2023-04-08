class CreateGoals : Goals
{
    public override string Name => "Create Goals";
    public override string Description => "";
    public override void Start()
    {
        base.Start();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Pick the type of Goal:");
            Console.WriteLine("1. Simple Goal:");
            Console.WriteLine("2. Eternal Goal:");
            Console.WriteLine("3. Checklist Goal:");
            Console.WriteLine("4. Back to Main Menu");

            Console.Write("What would you like to do?:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                        Goals.Run(new SimpleGoal());
                        break;
                    case "2":
                        Goals.Run(new EternalGoal());
                        break;
                    case "3":
                        Goals.Run(new ChecklistGoal());
                        break;
                    case "4":
                        running = false;
                        break;
            }
            
            
        } 
    }
}