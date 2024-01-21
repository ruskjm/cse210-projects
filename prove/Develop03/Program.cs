using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Nephi", 3, 5);
        Scripture s = new Scripture(r, "I will go and do.");
        //s.HideRandomWords(1);  

        Console.WriteLine("Welcome to the Scripture Memorizer program!");
        string input = "";
        
        while (input != "quit") {
            if (s.IsCompletelyHidden()) {
                break;
            }
            Console.WriteLine($"{s.GetDisplayWords()}");
            Console.WriteLine();
            Console.Write("Press enter to continue or type \"quit\" to exit: ");
            input = Console.ReadLine();
            s.HideRandomWords(2);
            
   
        }
    }
}