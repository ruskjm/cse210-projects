// The Reference class represents a scripture reference 
// with book, chapter, verse, and optional end verse
public class Reference {

    // Private fields to store reference details
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor to initialize a reference with book, chapter, verse
    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Overloaded constructor to initialize a reference with book, 
    // chapter, verse, endVerse
    public Reference(string book, int chapter, int verse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Display reference string
    // Will display end verse if one is passed in
    public string DisplayReference() {
        if(_endVerse > 0) {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        } else {
            return $"{_book} {_chapter}:{_verse}";
        }
    }

}