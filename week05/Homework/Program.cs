using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment1 = new Assignment("Phillip Illguth", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment assignment2 = new MathAssignment("Phillip Illguth", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        WritingAssignment assignment3 = new WritingAssignment("Mary Walters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}