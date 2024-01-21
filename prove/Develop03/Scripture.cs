public class Scripture {
    private Reference _reference;
    private List<Word> _words; 

    public Scripture(Reference reference, string text) {
        
        _reference = reference;
        string[] words = text.Split(" ");
        
        // Create Word object
        _words = new List<Word>();

        foreach(string wordText in words) {
            Word word = new Word(wordText);
            
            _words.Add(word);
        }

    }

    public String GetDisplayWords() {  

        string displayWords = _reference.DisplayScripture();

        foreach(Word word in _words) {
            displayWords += " " + word.DisplayWord();
        }

        return displayWords;

    }

    public void HideRandomWords(int numberToHide) {
        Random rand = new Random();
        List<int> indexes = new List<int>();

        while(indexes.Count < numberToHide) {
            int index = rand.Next(0, _words.Count);
            if(!indexes.Contains(index)) {
                indexes.Add(index);  
            }
        }
        
        foreach(int index in indexes) {
            _words[index].Hide();
        }
    }


    public bool IsCompletelyHidden() {
        return false;
    }
    
}