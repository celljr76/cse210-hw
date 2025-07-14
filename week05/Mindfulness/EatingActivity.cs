public class EatingActivity : Activity
{
    public EatingActivity(string name, string description) : base(name, description)
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
            Console.WriteLine("Take a bite");
            Console.WriteLine();
            Console.Write("Chew...");
            ShowCountDown(10);
        }
        Console.WriteLine();
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the Eating Activity.");
        Thread.Sleep(3000);
    }









}