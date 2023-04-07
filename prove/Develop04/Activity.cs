public abstract class Activity
{
    public abstract string Name { get; }
    public abstract string Description { get; }
    public int Duration { get; set; }

    public static void Run(Activity activity)
    {
        activity.Start();
    }
    
    public virtual void Start()
    {
        Console.WriteLine($"Starting {Name} Activity...");
        Console.WriteLine($"{Description}");

        
    }

    protected static void ShowSpinner(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write(".");
            Console.Write("\b \b");
            Console.Write(".");

            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine();
    }
    
}