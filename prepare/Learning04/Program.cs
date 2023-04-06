using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John", "Programming with Classes on C#");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        string problems = "How to find the slope intercept";
        MathAssignment assignment1 = new MathAssignment("Glenn", "Algebra", problems);
        string summary1 = assignment1.GetSummary();
        Console.WriteLine();
        Console.WriteLine(summary1);
        Console.WriteLine(problems);

        string words = "Why are other governments better than others?";
        WritingAssignment assignment2 = new WritingAssignment("Nate", "Political Science", words);
        Console.WriteLine();
        string summary2 = assignment2.GetSummary();
        Console.WriteLine(summary2);
        Console.WriteLine(words);

    }
}