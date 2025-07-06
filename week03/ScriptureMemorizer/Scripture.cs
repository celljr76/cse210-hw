public class Scripture
{
    public List<Word> _word = new List<Word>();
    public string _text = "";
    static char[] _separators = new char[] { ' '};
       
    
    public Scripture(string _texts)
    {
        _text = _texts;
        string[] _words = _text.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
        foreach (string i in _words)
        {
            _word.Add(new Word(i));
        }
    }

    public void HideRandomWords(int _numberToHide)
    {
        
        _word[_numberToHide].Hide();              

    }
    public string GetDisplayText()
    {
        _text = "";
        foreach (Word _words in _word)
        {
            _text += _words.GetDisplayText() + " ";
        }
        return _text;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
    public int GetRandomNumber()
    {
        Random _random = new Random();
        int _randomNumber = _random.Next(0, _word.Count());
        return _randomNumber;
    }

}