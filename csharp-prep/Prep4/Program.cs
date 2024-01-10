using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0) {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0) {
                numbers.Add(number);
            }
        }
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine("The sorted list is:");
        for (int i = 0; i < numbers.Count; i++) {
            int sort = numbers[i];
            Console.WriteLine(sort);
        }
    }
}