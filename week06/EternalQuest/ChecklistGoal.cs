public class ChecklistGoal : Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(points)
    {
        _points = points;
        _shortName = name;
        _description = description;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {

        return $"Checklist";
    }

}