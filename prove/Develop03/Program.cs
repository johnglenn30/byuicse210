using System;
using System.Linq;

public class Program
{
    public static string _scriptureText;

    public static void Main(string[] args)
    {
        Console.Clear();
        Scripture scripture = new Scripture();
        string scriptureText = Scripture.GetScripture();

        Console.WriteLine(scriptureText);
        Console.ReadKey(true);

        Console.Clear();
        Scripture scripture1 = new Scripture();

        Console.Clear();
        Console.WriteLine("Press any key to start. Press ESC to exit.");
        Console.ReadKey(true);

        Console.Clear();
        Scripture scripture2 = new Scripture();

        Random random = new Random();
        string[] words = scriptureText.Split(' ');
        bool[] blanks = Enumerable.Repeat(false, words.Length).ToArray();
        int blankCount = 0;

        while (true)
        {
            // Replace a random word with blanks
            int index;
            do
            {
                index = random.Next(words.Length);
            } while (blanks[index]);

            words[index] = new string('_', words[index].Length);
            blanks[index] = true;
            blankCount++;

            Console.Clear();
            string newText = string.Join(" ", words);
            Console.WriteLine(newText);

            // Exit if all words are blank
            if (blankCount == words.Length)
            {
                break;
            }

            ConsoleKeyInfo key = Console.ReadKey(true);

            // Exit if the user presses ESC
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }

    public class Scripture
    {
        public Scripture()
        {
            _scriptureText = "Trust in the LORD with all your heart, And lean not on your own understanding; In all your ways acknowledge Him, And He shall direct your paths.";
        }

        public static string GetScripture()
        {
            return _scriptureText;
        }
    }
}
