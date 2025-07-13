using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name,string description) : base(name,description)
    {
        
    }
    public void Run()
    {
        int _duration = DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in ...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.");
        Thread.Sleep(5000);
    }
}