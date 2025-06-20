using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Step 4
        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);

        //Step 5

        //job1.Displayjob();
        //job2.Displayjob();

        //Step 7

        Resume person1 = new Resume();
        person1._name = "Allison Rose";
        person1._jobs.Add(job1);
        person1._jobs.Add(job2);
        Console.WriteLine(person1._jobs[0]._jobTitle);

        //Step 8

        person1.Displaydetails();
        

    }
}