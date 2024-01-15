using System;
using System.IO; 
using System.Text.RegularExpressions;

public class Journal {
    public List<Entry> _entries = new List<Entry>();
    private string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }

    public void DisplayAll() {
         foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file) {

        string fullPath = Path.Combine(defaultPath, file);
        
        using (StreamWriter outputFile = new StreamWriter(fullPath)) {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date}  - Prompt: {entry._promptText}"); 
                outputFile.WriteLine($"Journal entry: {entry._entryText}");
                outputFile.WriteLine();
            }
        }
    }

    public void LoadfromFile(string file) {
        _entries.Clear();

        string fullPath = Path.Combine(defaultPath, file);

        using (StreamReader reader = new StreamReader(fullPath)) {
            string line;
            Entry entry = null;
            while ((line = reader.ReadLine()) != null) 
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
      
                if(line.Contains("Date:")) 
                {
                    // Start new entry
                    entry = new Entry();

                    // Extract the date
                    Regex dateRegex = new Regex(@"Date:\s*(.*?)\s*-");
                    Match dateMatch = dateRegex.Match(line);
                    entry._date = dateMatch.Groups[1].Value;
                    
                    // Extract the prompt
                    int index = line.IndexOf("Prompt:");
                    if(index != -1) 
                    {
                        entry._promptText = line.Substring(index + "Prompt:".Length).Trim();
                    }
                }           
                else if(line.Contains("Journal entry:"))
                {
                    // Extract the journal entry
                    int index2 = line.IndexOf("Journal entry:");
                    if(index2 != -1) 
                    {
                        entry._entryText = line.Substring(index2 + "Journal entry:".Length).Trim();
                    }
                    // Add completed entry 
                    _entries.Add(entry);
                }
            }
        }
    }
}