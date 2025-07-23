public class RunningActivity : Activity
{
	public RunningActivity(string name,double lengthInMinutes) : base(name,lengthInMinutes)
	{

	}

	public override double GetSpeed()
	{
		double speed = (GetDistance() / GetLengthInMinutes()) * 60;
		return speed;
	}
	public override double GetPace()
	{
		return GetLengthInMinutes() / GetDistance();
	}

	public override void GetSummary()
    {
        Console.WriteLine($"{DateTime.Now.ToString("dd MMM yyyy")} {GetName()} ({GetLengthInMinutes()} min): Distance {GetDistance()} miles, Speed {GetSpeed()}, Pace {GetPace()} min per mile");
    }
}