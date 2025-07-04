using System.Runtime.CompilerServices;
using System.Text;

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
        StringBuilder _stringBuilder = new StringBuilder(_word);
        _stringBuilder[0] = '_';
    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        return _word;
    }
}