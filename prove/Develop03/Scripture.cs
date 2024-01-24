// Class to represent scripture reference and scripture text
public class Scripture {

    // The scripture reference
    private Reference _reference;

    // List of Word objects making up text
    private List<Word> _words; 
    
    // Parameterless constructor
    public Scripture() { }

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

    // Method to return a random scripture
    public Scripture GetRandomScripture()
    {
        // Declare Reference object  
        Reference reference;

        // Declare Scripture object
         Scripture scripture = null;

        // Random scriptures that the program will choose from
        Random random = new Random();

        // Create a random number from 1-4
        int randomNumber = random.Next(1, 5);

        // Picks one of the scripture from the random number returned
        if (randomNumber == 1) {
            reference = new Reference("1 Nephi", 3, 7);
            scripture = new Scripture(reference, 
            "And it came to pass that I, Nephi, said unto my father: I will go and do " +
            "the things which the Lord hath commanded, for I know that the Lord giveth no " + 
            "commandments unto the children of men, save he shall prepare a way for them that " +
            "they may accomplish the thing which he commandeth them.");
        } else if (randomNumber == 2) {
            reference = new Reference("James", 1, 5, 6);
            scripture = new Scripture(reference, 
            "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, " + 
            "and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. "+
            "For he that wavereth is like a wave of the sea driven with the wind and tossed.");
         } else if (randomNumber == 3) {
            reference = new Reference("Moses", 1, 39);
            scripture = new Scripture(reference, 
            "For behold, this is my work and my glory, to bring to pass the immortality and eternal life of man.");
        } else if (randomNumber == 4) {
            reference = new Reference("Doctrine and Covenants", 58, 26, 27);
            scripture = new Scripture(reference, 
            "For behold, it is not meet that I should command in all things; " +
            "for he that is compelled in all things, the same is a slothful " + 
            "and not a wise servant; wherefore he receiveth no reward. " +
            "Verily I say, men should be anxiously engaged in a good cause, " +
            "and do many things of their own free will, and bring to pass much righteousness;");
        }   

        // Return the scripture instance
        return scripture;

    }

    
}