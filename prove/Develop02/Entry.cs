using System;

//Entry class for single journal entry
//Varibles date, promptText, entryText
public class Entry {
    public string _date;
    public string _promptText;
    public string _entryText;


    // Display() method prints out the details of a journal entry
    // Including the date, prompt text, and entry text
    public void Display() {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Journal entry: {_entryText}");
        Console.WriteLine();
    }

}