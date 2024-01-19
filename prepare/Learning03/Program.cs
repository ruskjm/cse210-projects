using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine($"{f1.GetFractionString()}");
        Console.WriteLine($"{f1.GetDecimalValue()}");

        // Console.WriteLine($"Top: {f1.GetTop()}");
        // Console.WriteLine($"Bottom: {f1.GetBottom()}");
        // f1.SetBottom(21);
        // Console.WriteLine($"Bottom: {f1.GetBottom()}");

        Fraction f2 = new Fraction(5);
        // Console.WriteLine($"Top: {f2.GetTop()}");
        // Console.WriteLine($"Bottom: {f2.GetBottom()}");
        // f2.SetTop(21);
        // Console.WriteLine($"Top: {f2.GetTop()}");
        Console.WriteLine($"{f2.GetFractionString()}");
        Console.WriteLine($"{f2.GetDecimalValue()}");

        Fraction f3 = new Fraction(3, 4);
        // Console.WriteLine($"Top: {f3.GetTop()}");
        // Console.WriteLine($"Bottom: {f3.GetBottom()}");
        // f3.SetBottom(21);
        // Console.WriteLine($"Bottom: {f3.GetBottom()}");
        Console.WriteLine($"{f3.GetFractionString()}");
        Console.WriteLine($"{f3.GetDecimalValue()}");

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"{f4.GetFractionString()}");
        Console.WriteLine($"{f4.GetDecimalValue()}");

         
    }
}