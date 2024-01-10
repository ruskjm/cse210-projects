using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string grade;
        if (percentage >= 90) {
            grade = "A";
        }
        else if (percentage >= 80) {
            grade = "B";
        }
        else if (percentage >= 70) {
            grade = "C";
        }
        else if (percentage >= 60) {
            grade = "D";
        }
        else {
            grade = "F";
        }

        Console.WriteLine($"Your final grade is an {grade}.");

        if (percentage >= 70) {
            Console.WriteLine("You passed the class!");
        }
        else{
            Console.WriteLine("You failed the class, try again!");
        }

    }
}