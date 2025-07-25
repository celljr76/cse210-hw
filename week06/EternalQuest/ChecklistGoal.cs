public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;    
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override int GetTotalPoints()
    {
        int _totalPoints = GetGoalPoints();
        if (_amountCompleted == _target)
        {
            _totalPoints = GetGoalPoints() + GetBonus();
        }
        return _totalPoints;
    }

    public override void RecordEvent()
    {
        _amountCompleted = GetAmountCompleted() + 1;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You have earned {GetTotalPoints()} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        }        
    }
    public override bool IsComplete()
    {
        bool _isComplete = false;
        if (_target == _amountCompleted)
        {
            _isComplete = true;
        }
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        string _detailsString = "";
		if (_target == _amountCompleted)
		{
			_detailsString = $"[X] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {_amountCompleted}/{_target}"; 
		}
		else
		{
		_detailsString = $"[ ] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
		
		}
		return _detailsString;
    }
    public override string GetStringRepresentation()
    {

        return $"ChecklistGoal:{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()},{GetTarget()},{GetBonus()}";
    }

}