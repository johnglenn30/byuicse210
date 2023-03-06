using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> prices = new List<float>{};

        float enterNum = -1;
        while (enterNum != 0)
        {
            Console.WriteLine("Type item price (type 0 to quit and get the total): ");

            string userInput = Console.ReadLine();
            enterNum = float.Parse(userInput);

            if (enterNum != 0)
            {
                prices.Add(enterNum);
            }
        }
        
        float sum = 0;
        foreach (float price in prices)
        {
            sum += price;
        }

        Console.WriteLine($"The total is: ${sum:0.00}");

        float average = ((float)sum) / prices.Count;
        Console.WriteLine($"The average price is: ${average:0.00}");

        float max = prices[0];

        foreach (float price in prices)
        {
            if (price > max)
            {
                max = price;
            }
        }
        Console.WriteLine($"The highest item price is: {max:0.00}");

    }

}