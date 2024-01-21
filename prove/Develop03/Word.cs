public class Word {
    private string _word;
    private bool _isHidden;

    public Word(string word) {
        _word = word;
        _isHidden = false;
    }

    public void Hide() {
        _isHidden = true;
    }

    public bool isHidden() {
        return _isHidden;
    }

    public string DisplayWord() {
        if(_isHidden) {
            String hidden = "";
            for(int i = 0; i < _word.Length; i++) {
            hidden += "_"; 
            }
            return hidden;
        } else {
            return _word;   
        }
    }
}