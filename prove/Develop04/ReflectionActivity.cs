class ReflectionActivity : Activity
{
    public override string Name => "Reflection Activity";
    public override string Description => "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    public  override void Start()
    {
        Console.WriteLine($"Starting {Name} Activity...");
        Console.WriteLine($"{Description}");

        string openingStatement = "Let's reflect on some positive memories. ";
        string[] phrases = new string[] {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        
        Console.Write("How many seconds do you need to think? ");
        int duration = Convert.ToInt32(Console.ReadLine());
        
        // Generate a random number between 0 and the length of the phrases array
        Random rnd = new Random();
        int randomIndex = rnd.Next(phrases.Length);
        
        // Print the opening statement and the randomly selected phrase
        Console.WriteLine(openingStatement + phrases[randomIndex]);
        
        // Wait for the specified duration
        Thread.Sleep(duration * 1000);
        ShowSpinner(duration);
        Console.WriteLine("Time's up!");

        string[] phrases2 = new string[] {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        
        Console.Write("How many seconds do you need to think for the reflection question? ");
        int length = Convert.ToInt32(Console.ReadLine());
        
        // Generate a random number between 0 and the length of the phrases array
        Random rand = new Random();
        int randomIndex2 = rand.Next(phrases.Length);
        
        // Print the opening statement and the randomly selected phrase
        Console.WriteLine(phrases2[randomIndex2]);
        
        // Wait for the specified duration
        Thread.Sleep(length * 1000);
        ShowSpinner(length);
        Console.WriteLine("Time's up!");
    }

    
}