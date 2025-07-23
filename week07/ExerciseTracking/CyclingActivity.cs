public class CyclingActivity : Activity
{
	public CyclingActivity(string name,double lengthInMinutes) : base(name,lengthInMinutes)
	{
	
	}
	public override double GetSpeed()
	{
		return (GetDistance() / GetLengthInMinutes()) * 60;
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