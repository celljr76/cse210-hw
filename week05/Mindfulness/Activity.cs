public class Activity
{
    List<string> _animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}.");
        Console.WriteLine();
        Console.Write("How long in seconds, would you like your session to be? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
    }

    public void ShowSpinner(int seconds)
    {

        DateTime _startTime = DateTime.Now;
        DateTime _futureTime = _startTime.AddSeconds(seconds);

        if (_startTime < _futureTime)
        {
            foreach (string symbol in _animationStrings)
            {
                Console.Write(symbol);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b   \b\b");
        }
    }
    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }
}