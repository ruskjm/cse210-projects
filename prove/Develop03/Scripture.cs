// Class to represent scripture reference and scripture text
public class Scripture {

    // The scripture reference
    private Reference _reference;

    // List of Word objects making up text
    private List<Word> _words; 

    // Constructor to take the text string and add to words list  
    public Scripture(Reference reference, string text) {
        // Store the passed in Reference object
        _reference = reference;

        // Split the text by space into an array of words
        string[] words = text.Split(" ");
        
        // Create Word object
        _words = new List<Word>();

        // Iterate through each word from the text 
        foreach(string wordText in words) {
            // Create a new Word instance for each word 
            Word word = new Word(wordText);
            
            // Add the new Word object to the list of words
            _words.Add(word);
        }
    }

    // Method to build display string
    public String GetDisplayWords() {  
        // Add reference string to start
        string displayWords = _reference.DisplayReference();

        // Iterate through each word
        foreach(Word word in _words) {
            // Append the display for each word
            displayWords += " " + word.DisplayWord();
        }
        // Return the concatenated string
        return displayWords;
    }

    // Method to hide words
    public void HideRandomWords(int numberToHide) {
        // Random number generator
        Random rand = new Random();

        // Track indexes of words to hide
        List<int> indexes = new List<int>();

        // Get random indexes until reaching number
        while(indexes.Count < numberToHide) {
            // Get random index
            int index = rand.Next(0, _words.Count);
              
            // Check if word is already hidden
            if(!_words[index].IsHidden()) {

                // Add index for hidden word    
                indexes.Add(index);
            }
        }

        // Hide stored indexes
        foreach(int index in indexes) {
            // Hide word at index
            _words[index].Hide();
        }
    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden() {
        // Iterate through all words
        foreach(Word word in _words) {
            // Checks if any word is not hidden
            if(!word.IsHidden()) {
                // If not all words are hidden return false
                return false; 
            }
        }
        // If all words are hidden return true
        return true;
    }
    
}