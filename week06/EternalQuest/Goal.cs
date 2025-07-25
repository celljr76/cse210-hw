public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
   
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetGoalName()
    {
        return _shortName;
    }
    public string GetGoalDescription()
    {
        return _description;
    }
    public virtual int GetGoalPoints()
    {
        return _points;
    }
    public virtual int GetTotalPoints()
    {
        return GetGoalPoints();
    }
    

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
    string _detailsString = "";
	bool _isComplete = IsComplete();

	if (_isComplete == true)
	{
		_detailsString = $"[X] {_shortName} ({_description})";
	}
	else if (_isComplete == false)
	{
		_detailsString = $"[ ] {_shortName} ({_description})";
	}
	return _detailsString;

    }
    public abstract string GetStringRepresentation();
}