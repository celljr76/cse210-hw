using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

    RunningActivity running = new RunningActivity("Running",30);
    running.SetDistance(1.5);
    CyclingActivity cycling = new CyclingActivity("Cycling",60);
    cycling.SetDistance(6.5);
    SwimmingActivity swimming = new SwimmingActivity("Swimming",30,100);

    activities.Add(running);
    activities.Add(cycling);
    activities.Add(swimming);

    foreach (Activity activity in activities)
    {
        activity.GetSummary();
    }

    }
}