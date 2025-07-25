public class BreathingActivity : Activity
{
    public BreathingActivity(string name,string description) : base(name,description)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.Clear();
        DisplayGetReady();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {

            Console.Write("Breathe in ...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the Breathing Activity.");
        Thread.Sleep(3000);
    }
}