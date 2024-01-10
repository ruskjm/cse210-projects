using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        bool guesses = true;
        int counter = 0;

        while (guesses) {
            Console.WriteLine("Guess a number from 1-100");
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);

            if (guess > number) {
                Console.WriteLine("Lower");
                counter++;
            } else if (guess < number) {
                Console.WriteLine("Higher");
                counter++;
            } else {
                guesses = false;
                counter++;
                Console.WriteLine($"You guessed it in {counter} tries!");
            }
        }
        
    }

}