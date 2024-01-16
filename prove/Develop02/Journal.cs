using System;
using System.IO; 
using System.Text.RegularExpressions;

//Journal class represents a journal
public class Journal {
    //Internal list to store journal entries
    public List<Entry> _entries = new List<Entry>();

    //Set the default path where to save the file
    //Found an example on how to do this at
    //https://learn.microsoft.com/en-us/dotnet/api/system.environment.getfolderpath?view=net-8.0
    public string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    //AddEntry() method allows adding a new journal Entry
    public void AddEntry(Entry newEntry) {
        //Adds new journal entry
        _entries.Add(newEntry);
    }

    //DisplayAll() displays all journal entries
    public void DisplayAll() {
        //Iterate through all entries
         foreach (Entry entry in _entries)
        {
            //Displays each entry
            entry.Display();
        }
    }

   //SaveToFile() saves all journal entries to a file
    public void SaveToFile(string file) {

        //Sets the location to save the file and the name
        //Found an example on how to do this at
        //https://learn.microsoft.com/en-us/dotnet/api/system.io.path.combine?view=net-8.0
        string fullPath = Path.Combine(defaultPath, file);
        
        //Open file stream for writing
        using (StreamWriter outputFile = new StreamWriter(fullPath)) {
            //Iterate through all entries
            foreach (Entry entry in _entries)
            {
                //Write each line to file
                outputFile.WriteLine($"Date: {entry._date}  - Prompt: {entry._promptText}"); 
                outputFile.WriteLine($"Journal entry: {entry._entryText}");
                outputFile.WriteLine();
            }
        }
    }

    //LoadFromFile() loads saved journal entries from a file
    public void LoadfromFile(string file) {
        //Clear existing entries before loading
        _entries.Clear();

        //Sets the location to save the file and the name
        //Found an example on how to do this at
        //https://learn.microsoft.com/en-us/dotnet/api/system.io.path.combine?view=net-8.0
        string fullPath = Path.Combine(defaultPath, file);

        //Open file for reading
        using (StreamReader reader = new StreamReader(fullPath)) {
            string line;
            Entry entry = null;
            //Read file line by line 
            while ((line = reader.ReadLine()) != null) 
            {
                //Skip blank lines
                if (string.IsNullOrWhiteSpace(line)) continue;

                //Only execute if the line contains Date:
                if(line.Contains("Date:"))
                {
                    // Start new entry
                    entry = new Entry();

                    //Use regex to extract date
                    //Found an example on how to do this at
                    //https://www.dotnetperls.com/regex
                    //Create a regular expression to match a date pattern like "Date: some date -"
                    Regex dateRegex = new Regex(@"Date:\s*(.*?)\s*-");
                    //Use the regex to search for a date match in the input string (line)
                    Match dateMatch = dateRegex.Match(line);
                    //If a match is found, extract the date text from match group 1
                    //and assign it to the _date field of the entry object
                    entry._date = dateMatch.Groups[1].Value;
                    
                    //Extract the prompt and assign it to the _promptText field of the entry object
                    int index = line.IndexOf("Prompt:");
                    //Do not add if there is no index
                    if(index != -1) 
                    {
                        entry._promptText = line.Substring(index + "Prompt:".Length).Trim();
                    }
                }    
                //Only execute if the line contains Journal entry:       
                else if(line.Contains("Journal entry:"))
                {
                    //Extract the journal entry and assign it to the _entryText field of the entry object
                    int index2 = line.IndexOf("Journal entry:");
                    //Do not add if there is no index
                    if(index2 != -1) 
                    {
                        entry._entryText = line.Substring(index2 + "Journal entry:".Length).Trim();
                    }

                    //Add completed entry 
                    _entries.Add(entry);
                }
            }
        }
    }
}