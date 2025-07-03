using System.Runtime.CompilerServices;

public class Scripture
{
    public List<Word> _words;
    static string _text = "Trust in the Lord with all thine heart and lean not unto thine own\nunderstanding; in all thy ways acknowledge him, and he shall direct thy paths.";
    static char[] _separators = new char[] {' ', ',', ';', '.'};
    public string[] _word = _text.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
    
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