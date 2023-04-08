public abstract class Goals
{
    public abstract string Name { get; }
    public abstract string Description { get; }
    public int Duration { get; set; }

    public static void Run(Goals goals)
    {
        goals.Start();
    }
    
    public virtual void Start()
    {
        Console.WriteLine($"Starting {Name} Activity...");
        Console.WriteLine($"{Description}");

        
    }


    
}