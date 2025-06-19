using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Transactions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int number = -1;
        

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        int total = numbers.Sum();
        Console.WriteLine($"The sum is : {total}");
        int listCount = numbers.Count;
        Console.WriteLine($"The average is: {total / listCount}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}