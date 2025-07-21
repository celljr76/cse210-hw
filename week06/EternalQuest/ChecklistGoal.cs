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
    public override void RecordEvent()
    {
        _amountCompleted = GetAmountCompleted() + 1;
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
        return $"[ ] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {

        return $"Checklist:{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()},{GetTarget()},{GetBonus()}";
    }

}