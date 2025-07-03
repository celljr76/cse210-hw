public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _startVerse;
    public int _endverse;
    public void ReferenceShort(string _bookName, int _chapterNumber, int _verseNumber)
    {
        _book = _bookName;
        _chapter = _chapterNumber;
        _verse = _verseNumber;


    }

    public void ReferenceMultiple(string _bookName, int _chapterNumber, int _startVerseNumber, int _endverseNumber)
    {
        _book = _bookName;
        _chapter = _chapterNumber;
        _startVerse = _startVerseNumber;
        _endverse = _endverseNumber;
    }
    public string GetDisplayTextShort()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    public string GetDisplayTextMultiple()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endverse}";
    }
    
}