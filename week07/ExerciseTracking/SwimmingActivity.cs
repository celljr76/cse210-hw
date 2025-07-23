public class SwimmingActivity : Activity
{
	private int _laps;
	public SwimmingActivity(string name,double lengthInMinutes, int laps) : base(name,lengthInMinutes)
	{
		_laps = laps;
	}
	public override void GetSummary()
	{
        DateTime date = DateTime.Now;
        string formattedDate = date.ToString("dd MMM yyyy");
        Console.WriteLine($"{formattedDate} {GetName()} ({_laps} laps): Distance {GetDistance()} miles, Speed {GetSpeed()}, Pace{GetPace()} min per mile");
	}
	public override double GetDistance()
	{
		return _laps * 50 / 1000 * 0.62;
	}
	public override double GetPace()
	{
        return GetLengthInMinutes() / GetDistance();
	}
	public override double GetSpeed()
	{
        double speed = GetDistance() / GetLengthInMinutes() * 60;
        return speed;
	}
	
}