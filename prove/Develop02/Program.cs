/*
Developer: Jason Rusk
CSE 210: Programming with Classes
Week 02 Develop: Journal Program

Journal program contains the following features:
1. Provide random prompts for the user to give journals ideas/topics.
2. Write a new entry - Show the user a random prompt, and save their response, the prompt, and 
   the date as an Entry.
3. Display the journal - Iterate through all entries in the journal and display them to the screen.
4. Save the journal to a file - Prompt the user for a filename and then save the current journal 
   (the complete list of entries) to that file location.
5. Load the journal from a file - Prompt the user for a filename and then load the journal 
   (a complete list of entries) from that file. This should replace any entries currently stored 
   the journal.
6. Provide a menu that allows the user choose these options.

Classes:
JournalMenu: Displays the list of menu options for the user to pick from.
JournalOptions: Run the options selected by the user.
RandomPrompt: Returns a random prompt from a list.
Entry: Used for single journal entry to display the prompt, date and journal entry.
Journal: Adds each journal entry to from the Entry class.
         Displays all journal entries from the list.
         Loads all the journal entries from a file.
         Saves all the journal entries to a file.
*/

using System;

//The Program class serves as the entry point for the application.
class Program
{
    static void Main(string[] args)
    {
      //Create a new JournalOptions object
      JournalOptions options = new JournalOptions();

      //Create a new JournalMenu object
      JournalMenu menu = new JournalMenu();

      //Create int for menu options
      int option = -1;

      //Display welcome greeting
      Console.WriteLine("Welcome to your journal!");

      //Enter a blank line
      Console.WriteLine();

      //Continue until the using enters 5
      while (option != 5) {

         //Display the menu from the JournalMenu class
         menu.ShowMenu();

         //Get menu options entered from JournalMenu class
         option = menu.GetMenuSelection();

         //Enter a blank line
         Console.WriteLine();
          
         //Get journal options from JournalOptions class
         options.ProcessOptions(option);
         }

      //Display message after entering the journal 
      Console.WriteLine("You have exited your journal!");
    } 
}