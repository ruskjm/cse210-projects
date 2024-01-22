using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference;
        Scripture scripture = null;

        Random random = new Random();
        int randomNumber = random.Next(1, 4);
        if (randomNumber == 1) {
            reference = new Reference("1 Nephi", 3, 7, 8);
            scripture = new Scripture(reference, 
            "And it came to pass that I, Nephi, said unto my father: I will go and do " +
            "the things which the Lord hath commanded, for I know that the Lord giveth no " + 
            "commandments unto the children of men, save he shall prepare a way for them that " +
            "they may accomplish the thing which he commandeth them.");
        } else if (randomNumber == 2) {
            reference = new Reference("1 Nephi", 3, 7);
            scripture = new Scripture(reference, 
            "And it came to pass that I, Nephi, said unto my father: I will go and do " +
            "the things which the Lord hath commanded, for I know that the Lord giveth no " + 
            "commandments unto the children of men, save he shall prepare a way for them that " +
            "they may accomplish the thing which he commandeth them.");
        } else if (randomNumber == 3) {
            reference = new Reference("1 Nephi", 3, 7, 10);
            scripture = new Scripture(reference, 
            "And it came to pass that I, Nephi, said unto my father: I will go and do " +
            "the things which the Lord hath commanded, for I know that the Lord giveth no " + 
            "commandments unto the children of men, save he shall prepare a way for them that " +
            "they may accomplish the thing which he commandeth them.");
        }  

        Console.WriteLine("Welcome to the Scripture Memorizer program!");
        String removeText = "";
        int remove = 1;
        string input;

        // Display original scriptute
        Console.WriteLine();
        Console.WriteLine("Your scripture is:");
        Console.WriteLine();
        if (scripture != null) {
            Console.WriteLine(scripture.GetDisplayWords());
        }
        Console.WriteLine();
        
        while(true) {
            Console.Write("Press enter to continue or type \"quit\" to exit: ");
            input = Console.ReadLine();

            if(input.ToLower() == "quit") {
                break;
            }

            if (string.IsNullOrEmpty(removeText)) {
                Console.WriteLine();
                Console.Write("How many words would you like to remove at a time? ");
                removeText = Console.ReadLine();
                int.TryParse(removeText, out remove);
                Console.WriteLine();
            }

            scripture.HideRandomWords(remove);
            Console.WriteLine(scripture.GetDisplayWords());   
            Console.WriteLine();  

            if (scripture.IsCompletelyHidden()) {
                Console.WriteLine();
                Console.WriteLine("All words have been removed.");
                Console.WriteLine();
                break;
            }
        }
    Console.WriteLine();
    Console.WriteLine("Thank you for using the Scripture Memorizer program!");
    Console.WriteLine();
   }
}
