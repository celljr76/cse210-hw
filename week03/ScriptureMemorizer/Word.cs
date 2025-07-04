using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

public class Word
{
    public string _word;
    public bool _isHidden;
    public  Word(string _words)
    {
        _word = _words;
    }

    public void Hide()
    {
       _isHidden = true;    
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string _text = "";
        if (_isHidden == false)
        {
            _text = _word;
        }
        else if (_isHidden == true)
        {
           _text = new String('_', _word.Length);
        }
        return _text;
    }
}