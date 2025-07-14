public class ReflectingActivity : Activity
{

    public List<string> _questions = new List<string> {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?", "What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    public List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time When you helped someone in need.","Think of a time when you did something truly selfless." };
    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int stringindex = random.Next(0, _prompts.Count());
        return _prompts[stringindex];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int stringindex = random.Next(0, _questions.Count());

        return _questions[stringindex];
    }

    public void DisplayPrompt()
    {
        Console.Write(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
    }
    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.Clear();
        DisplayGetReady();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.Write("--- ");
        DisplayPrompt();
        Console.Write(" ---");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.Write("Now ponder on each of the following questions as they are related to this experience.\nYou may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            DisplayQuestions();
            ShowSpinner(5);

        }
        Console.WriteLine();
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the Reflecting Activity.");
        Thread.Sleep(3000);
    }
}