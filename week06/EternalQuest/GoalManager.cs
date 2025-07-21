public class GoalManager
{
    private List<Goal> _goals;
    private int _score = 0;
    

    public GoalManager()
    {
        _goals = new List<Goal>();
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
            string[] parts = goal.GetDetailsString().Split(' ');
            string name = parts[2];
            int index = _goals.IndexOf(goal);
            Console.WriteLine($"{index + 1}. {name}");
            
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
            Console.WriteLine();
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
             
        
    }
    public void Savegoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                string goals = goal.GetStringRepresentation();
                Console.WriteLine(goals);
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
        for (int i = 0; i < lines.Count(); i++)
        {
            if (i == 0)
                continue;
            foreach (string line in lines)
            {
                string[] parts = line.Split(seperators);
                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(simpleGoal);
                }
                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(eternalGoal);
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    _goals.Add(checklistGoal);
                }
                
            }
        }
        
    }
}