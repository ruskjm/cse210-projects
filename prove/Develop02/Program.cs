using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a new RandomPrompt object
        RandomPrompt random = new RandomPrompt();

        //Create a new Journal object
        Journal journal = new Journal();

        //Create string for menu options
        int option = -1;

        //Continue until the using enters 5
        while (option != 5) {

            //Create a new JournalMenu object
            JournalMenu menu = new JournalMenu();

            //Display the menu from the JournalMenu class
            menu.ShowMenu();

            //Get menu option entered from JournalMenu class
            option = menu.GetMenuSelection();

            //Enter a blank line
             Console.WriteLine();

            //If option 1 add entry to journal
            if (option == 1) {
                //Create a new Entry object
                Entry entry = new Entry();
                //Get a random prompt text from the RandomPrompt object
                //and assign it to the promptText property of the entry object
                Console.WriteLine(entry._promptText = random.GetRandomPrompt());
                //Get current date and assign it to the _date property of the entry object
                entry._date = DateTime.Now.ToShortDateString();
                Console.Write(">");
                //Read in the jounral entry from the user
                entry._entryText = Console.ReadLine();
                //Add the journal entry object to the Journal
                journal.AddEntry(entry);
                //Enter a blank line
                Console.WriteLine();
            //If option 2 display all to journal entries
            } else if (option == 2) {
                //Call the DisplayAll() method on the Journal object
                //and display all journal entries
                journal.DisplayAll();
                //Enter a blank line
                Console.WriteLine();
            //If option 3 load journal from file
            } else if (option == 3) {
                Console.Write("Enter file name to load. ");
                //Read in the file name from the user
                string file = Console.ReadLine();
                //Load journal entries from a file
                journal.LoadfromFile(file);
                Console.WriteLine("File loaded");
            //If option 4 save journal to file
            }else if (option == 4) {
                Console.Write("Enter file name to save. ");
                //Read in the file name from the user
                string file = Console.ReadLine();
                //Save journal entries to a file
                journal.SaveToFile(file);
                Console.WriteLine("File saved");
            } 
        }
        Console.WriteLine("You have exited your journal!");
    }
}