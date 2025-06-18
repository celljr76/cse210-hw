using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradeNumber = int.Parse(userInput);
        string letter = "";
        int lastNumber = gradeNumber % 10;
        string sign = "";
        if (gradeNumber >= 90)
        {
            if (lastNumber < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            if (lastNumber >= 7)
            {
                sign = "+";
            }
            else if (lastNumber < 3)
            {
                sign = "-";
            }
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
             if (lastNumber >= 7)
            {
                sign = "+";
            }
            else if (lastNumber < 3)
            {
                sign = "-";
            }
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
             if (lastNumber >= 7)
            {
                sign = "+";
            }
            else if (lastNumber < 3)
            {
                sign = "-";
            }
            letter = "D";
        }
        else if (gradeNumber < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is a {letter}{sign}");
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congradulations you passed the class, way to go!");
        }
        else if (gradeNumber <= 70)
        {
            Console.WriteLine("You failed the class. I know you can do better next time.");
        }
            
        


    }
}