public class GoalManager
{
    private List<Goal> _goals;
    private int _score;


    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public int GetScore()
    {
        return _score;
    }
    public void Start()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {

            int index = _goals.IndexOf(goal);
            Console.WriteLine($"{index + 1}. {goal.GetGoalName()}");

        }

    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            int index = _goals.IndexOf(goal);
            Console.WriteLine($"{index + 1}. {goal.GetDetailsString()}");

        }

    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        int _choice = int.Parse(Console.ReadLine());
        if (_choice == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);


        }
        else if (_choice == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (_choice == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int _choice = int.Parse(Console.ReadLine());
        _goals[_choice - 1].RecordEvent();
        _score = GetScore() + _goals[_choice - 1].GetTotalPoints();
        Console.WriteLine($"You now have {GetScore()} points.");
        Console.WriteLine();
    }
    public void Savegoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        char[] seperators = { ':', ',' };
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        foreach (string line in lines)
        {
            string _string = line.Split(seperators)[0];
            if (_string != null)
            {
                int simpleTrue = String.Compare(_string, "SimpleGoal");
                int eternalTrue = String.Compare(line.Split(seperators)[0], "EternalGoal");
                int checkListTrue = String.Compare(line.Split(seperators)[0], "ChecklistGoal");

                if (simpleTrue == 0)
                {
                    string[] parts = line.Split(seperators);
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(simpleGoal);
                }

                else if (eternalTrue == 0)
                {
                    string[] parts = line.Split(seperators);
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(eternalGoal);
                }
                else if (checkListTrue == 0)
                {
                    string[] parts = line.Split(seperators);
                    ChecklistGoal checkListGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    _goals.Add(checkListGoal);

                }
            }

        }
    }
}