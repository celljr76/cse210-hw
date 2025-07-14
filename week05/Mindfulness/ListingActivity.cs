public class ListingActivity : Activity
{

    public int _count;
    public List<string> _prompts = new List<string>{"Who do you appreciate in your life?","What are some personal strengths of yours?", "Who have you helped this week?","When have you felt the holy Ghost this month?","Who are some of your personal heros?"};

    public ListingActivity(string name, string description) : base(name,description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.Clear();
        DisplayGetReady();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> userList = GetListFromUser();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        }
        _count = userList.Count();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {duration} seconds of the Listing Activity.");
        Thread.Sleep(3000);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int _stringindex = random.Next(0, _prompts.Count());
        return _prompts[_stringindex];
    }

    public List<string> GetListFromUser()
    {
        List<string> _userList = new List<string>();
        return _userList;
    }
}