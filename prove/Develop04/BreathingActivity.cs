public class BreathingActivity : Activity
{
    public override string Name { get { return "Breathing"; } }
    public override string Description { get { return "Breathe in and out for a set number of seconds."; } }

    public override void Start()
    {
        
        Console.WriteLine($"Starting {Name} Activity...");
        Console.WriteLine($"{Description}");

        PerformBreathingExercise();

        Console.WriteLine($"Good job! You have completed the {Name} Activity.");
        Console.WriteLine();
    }


    public void PerformBreathingExercise()
    {
        Console.WriteLine("Performing breathing exercise...");
        Console.WriteLine("Breathe in for 4 seconds...");
        ShowSpinner(4);

        Console.WriteLine("Hold your breath for 7 seconds...");
        ShowSpinner(7);

        Console.WriteLine("Breathe out for 8 seconds...");
        ShowSpinner(8);

        Console.WriteLine("Repeat for the duration of the activity.");
        Console.WriteLine();
    }
}
