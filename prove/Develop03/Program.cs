/*
Developer: Jason Rusk
CSE 210: Programming with Classes
Week 03 Develop: Scripture Memorizer

Functional requirements
Your program must do the following:

1. Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.

2. Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".

3. Clear the console screen and display the complete scripture, including the reference and the text.

4. Prompt the user to press the enter key or type quit.

5. If the user types quit, the program should end.

6. If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again.

7. The program should continue prompting the user and hiding more words until all words in the scripture are hidden.

8. When all words in the scripture are hidden, the program should end.

9. When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)

Classes:
Program: Main application class
Scripture: Class to represent scripture reference and scripture text.
Word: Class to represent a word that can be hidden.
Reference: Class represents a scripture reference with book, chapter, verse, and optional end verse.

Stretch comments:
I did the below beyond the core requirements:

1. Created random scriptures that are selected at the start of the program.

2. Allowed the user to select how many words to remove on each round.

*/


using System;

// Main application class
class Program
{
    // Entry point for application
    static void Main(string[] args)
    {
        // Declare Reference variable  
        // Will hold scripture reference
        Reference reference;

        // Declare Scripture variable
        // Initialize to null initially
        Scripture scripture = null;

        // Random scriptures that the program will choose from
        Random random = new Random();

        // Create a random number from 1-4
        int randomNumber = random.Next(1, 5);

        // Picks one of the scripture from the random number returned
        if (randomNumber == 1) {
            reference = new Reference("1 Nephi", 3, 7);
            scripture = new Scripture(reference, 
            "And it came to pass that I, Nephi, said unto my father: I will go and do " +
            "the things which the Lord hath commanded, for I know that the Lord giveth no " + 
            "commandments unto the children of men, save he shall prepare a way for them that " +
            "they may accomplish the thing which he commandeth them.");
        } else if (randomNumber == 2) {
            reference = new Reference("James", 1, 5, 6);
            scripture = new Scripture(reference, 
            "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, " + 
            "and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. "+
            "For he that wavereth is like a wave of the sea driven with the wind and tossed.");
         } else if (randomNumber == 3) {
            reference = new Reference("Moses", 1, 39);
            scripture = new Scripture(reference, 
            "For behold, this is my work and my glory, to bring to pass the immortality and eternal life of man.");
        } else if (randomNumber == 4) {
            reference = new Reference("Doctrine and Covenants", 58, 26, 27);
            scripture = new Scripture(reference, 
            "For behold, it is not meet that I should command in all things; " +
            "for he that is compelled in all things, the same is a slothful " + 
            "and not a wise servant; wherefore he receiveth no reward. " +
            "Verily I say, men should be anxiously engaged in a good cause, " +
            "and do many things of their own free will, and bring to pass much righteousness;");
        }  

        // Display welcome message
        Console.WriteLine("Welcome to the Scripture Memorizer program!");

        // Variable used for user prompt
        String removeText = "";

        // Creates and defaults the remove to 1
        int remove = 1;

        // Variable used for user prompt
        string input;

       
        // Blank line
        Console.WriteLine();

        // Message to display
        Console.WriteLine("Your scripture is:");

        // Blank line
        Console.WriteLine();

        // Display original scripture
        if (scripture != null) {
            Console.WriteLine(scripture.GetDisplayWords());
        }
        // Blank line
        Console.WriteLine();
        
        // Will continue until false
        while(true) {
            // Prompts the user and stores response
            Console.Write("Press enter to continue or type \"quit\" to exit: ");
            input = Console.ReadLine();

            // Breaks out of while look if the user types quit
            if(input.ToLower() == "quit") {
                break;
            }

            // Checks that the removeText is valued
            if (string.IsNullOrEmpty(removeText)) {
                // Blank line
                Console.WriteLine();
                // Prompts and store the value enter by the user for how many words to remove
                Console.Write("How many words would you like to remove at a time? ");
                removeText = Console.ReadLine();
                // Convert removeText to int remove
                int.TryParse(removeText, out remove);

                // Blank line
                Console.WriteLine();
            }

            // This will clear the console
            Console.Clear();

            // Calls HideRandomWords method from Scripture class
            // and hides the randomly determined number of words
            scripture.HideRandomWords(remove);

            // Calls GetDisplayWords method from Scripture class
            // and displays the scripture with hidden words
            Console.WriteLine(scripture.GetDisplayWords()); 


            // Blank line  
            Console.WriteLine();  

            // Calls IsCompletelyHidden method from Scripture class
            // Checks if all words have been hidden
            if (scripture.IsCompletelyHidden()) {
                // Blank line  
                Console.WriteLine();
                // Message to display

                Console.WriteLine("All words have been removed.");

                // If all words have been hidden breaks out of while loop
                break;
            }
        }
    // Blank line 
    Console.WriteLine();

    // Display message when the program exits
    Console.WriteLine("Thank you for using the Scripture Memorizer program!");

    // Blank line 
    Console.WriteLine();
   }
}
