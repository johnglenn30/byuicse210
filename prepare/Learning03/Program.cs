using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Console.WriteLine(fraction1.DisplayFraction());
        Console.WriteLine(fraction1.DisplayDecimal());

        Fractions fraction2 = new Fractions(5);
        Console.WriteLine(fraction2.DisplayFraction());
        Console.WriteLine(fraction2.DisplayDecimal());

        Fractions fraction3 = new Fractions(3, 4);
        Console.WriteLine(fraction3.DisplayFraction());
        Console.WriteLine(fraction3.DisplayDecimal());

        Fractions fraction4 = new Fractions(1, 3);
        Console.WriteLine(fraction4.DisplayFraction());
        Console.WriteLine(fraction4.DisplayDecimal());

    }
}