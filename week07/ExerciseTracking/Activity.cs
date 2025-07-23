public abstract class  Activity
{
private string _name;
	private double _lengthInMinutes;
	private double _distance;
	public Activity(string name, double lengthInMinutes)
	{
		_name = name;
		_lengthInMinutes = lengthInMinutes;		
	}
    public abstract void GetSummary();
    
    public string GetName()
	{
		return _name;
	}
	public void SetDistance(double distance)
	{
		_distance = distance;
	}
	public virtual double GetDistance()
	{
		return _distance;
	}
	public double GetLengthInMinutes()
	{
		return _lengthInMinutes;
	}
	public abstract double GetSpeed();
	public abstract double GetPace();
}