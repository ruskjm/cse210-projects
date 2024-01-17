using System;

//Class to show menu and read in user menu option
public class JournalMenu
{
    //Show menu options
    public void ShowMenu()
    {
        //Menu options
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine(); 
        Console.WriteLine("Select one of the following options:");
        Console.WriteLine("1. Write a journal entry"); 
        Console.WriteLine("2. Display journal entry");
        Console.WriteLine("3. Load journal from file"); 
        Console.WriteLine("4. Save journal to file");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    //Read in option entered by the user as an int
    public int GetMenuSelection()
    {
        string input = Console.ReadLine();
        return int.Parse(input);
    }
}