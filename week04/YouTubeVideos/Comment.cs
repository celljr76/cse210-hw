using System.ComponentModel.DataAnnotations;

public class Comment
{
    public string _userName;
    public string _comment;
    public Comment(string userName, string comment)
    {
        _userName = userName;
        _comment = comment;
    }
    public string GetComment()
    {
        return $"{_userName}\n{_comment}";
    }
}