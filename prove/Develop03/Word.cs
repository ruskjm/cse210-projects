// Class to represent a word that can be hidden
public class Word {
    // The private word text
    private string _word;
    
     // The priavte boolean to check if word currently hidden
    private bool _isHidden;

    // Constructor sets the word and defaults _isHidden to false
    public Word(string word) {
        _word = word;
        _isHidden = false;
    }

    // Method to hide the word 
    public void Hide() {
        _isHidden = true;
    }

    // Check if word is hidden
    public bool IsHidden() {
        return _isHidden;
    }

    // Display the word or dashes to the length of the word
    public string DisplayWord() {
        // Check if the word is hidden
        if(_isHidden) {
            String hidden = "";
            // Loops thru the lenght of the hidden and sets a "-" for the length
            for(int i = 0; i < _word.Length; i++) {
                hidden += "_"; 
            }
            // Returns hidden string
            return hidden;
        // If the word is not hidden returns the word
        } else {
            // Returns word string
            return _word;   
        }
    }
}