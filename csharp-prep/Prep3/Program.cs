using System;

class Program
{ 
    static void Main(string[] args)
    {

        Random randomNumbers = new Random();
        int numbers = randomNumbers.Next(1,11);

        int numberGuess = -1;

        while (numberGuess != numbers)
        
            {
                Console.Write("Guess the number.");
                numberGuess = int.Parse(Console.ReadLine());

                if (numbers > numberGuess) {
                    Console.WriteLine("Higher");
                }
                else if (numbers < numberGuess) {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You got it!");
                }

            }
        }
    }