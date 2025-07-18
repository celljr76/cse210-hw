public class Video
{
    public string _title;
    public string _author;
    public double _lengthInSeconds;
    public List<string> comments = new List<string>();

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = TimeSpan.Parse(length).TotalSeconds;
    }
    public int GetCount()
    {
        return comments.Count();

    }
    public string GetVideo()
    {
        return $"{_title}\n{_author}\n{_lengthInSeconds}";
    }
}