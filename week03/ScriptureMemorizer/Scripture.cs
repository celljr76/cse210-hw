


public class Scripture
{
    public List<Word> _word = new List<Word>();
    public string _text = "";
    public char[] _separators = new char[] { ' ', ',', ';', '.' };
    public Scripture(string _texts)
    {
        _text = _texts;
        string[] _words = _text.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
        foreach (string i in _words)
        {
            _word.Add(new Word (i));
        } 
    }
            
    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
    
        return _text;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }


}