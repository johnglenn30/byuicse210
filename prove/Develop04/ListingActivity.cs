class ListingActivity : Activity
{
    public override string Name => "Listing Activity";
    public override string Description => "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public override void Start()
    {
        Console.WriteLine($"Starting {Name} Activity...");
        Console.WriteLine($"{Description}");

        string openingStatement = "Type in your answers.";
        string[] phrases = new string[] {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        Console.Write("How many seconds do you need to type? ");
        int duration = Convert.ToInt32(Console.ReadLine());

        // Generate a random number between 0 and the length of the phrases array
        Random rnd = new Random();
        int randomIndex = rnd.Next(phrases.Length);

        // Print the opening statement and the randomly selected phrase
        Console.WriteLine(openingStatement + " " + phrases[randomIndex]);

        Console.Write("Enter a word or phrase, separate with a comma (Do not Press enter): ");

        string input = "";
        Thread inputThread = new Thread(() => {
            input = Console.ReadLine();
        });

        inputThread.Start();
        ShowSpinner(duration);
        inputThread.Join();

        Console.WriteLine("Time's up!");

        Console.WriteLine("You typed: " + input);
    }

    protected static void ShowSpinner(int duration)
    {
        Console.Write("Timer: ");
        for (int i = 0; i < duration; i++)
        {
            Console.Write(".");
            Console.Write("\b \b");
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
