using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        var myList = new List<int> { 1, 2, 3, 4, 5 };
for (int i = 0; i < myList.Count; i++)
{
    if (i == 2) // Skip index 2
        continue;

    Console.WriteLine(myList[i]);
}

    }
}