//Class to show menu and read in user menu option
public class Menu
{
    //Show menu options method
    public void ShowMenu()
    {
        //Menu options
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start breathing activity");
        Console.WriteLine("\t2. Start reflection activity");
        Console.WriteLine("\t3. Start listing activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    //Method to read in option entered by the user
    public string GetMenuSelection()
    {
        // Read in user input
        string input = Console.ReadLine();

        // Return user input
        return input;
    }
}