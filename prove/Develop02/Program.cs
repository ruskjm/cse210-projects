using System;

class Program
{
    static void Main(string[] args)
    {
        RandomPrompt random = new RandomPrompt();
        Journal journal = new Journal();

        string option = "";

        while (option != "5") {
            Entry entry = new Entry();

            Console.WriteLine("Welcome to your journal!");
            Console.WriteLine();
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("1. Write a journal entry");
            Console.WriteLine("2. Display journal entry");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();
            Console.WriteLine();

            if (option == "1") {
                Console.WriteLine(entry._promptText = random.GetRandomPrompt());
                entry._date = DateTime.Now.ToShortDateString();
                Console.Write(">");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
                Console.WriteLine();
            } else if (option == "2") {
                journal.DisplayAll();
                Console.WriteLine();
            } else if (option == "3") {
                Console.Write("Enter file name to load. ");
                string file = Console.ReadLine();
                journal.LoadfromFile(file);
                Console.WriteLine("File loaded");
            }else if (option == "4") {
                Console.Write("Enter file name to save. ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("File saved");
            } 
        }
        Console.WriteLine("You have exited your journal!");
    }
}