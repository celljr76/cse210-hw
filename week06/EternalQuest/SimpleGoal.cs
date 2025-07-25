public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description,int points) : base(name,description,points)
    {

    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        _isComplete = true;
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
     public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()}";
    }

}
