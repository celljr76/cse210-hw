using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        //Part 1 and part 2
        //string magicNumber = Console.ReadLine();
        //int number = int.Parse(magicNumber);

        // Using this integer to start the while loop
        int var = 8;

        //Part 3

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        while (var == 8)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber == magicNumber)
            {
                var = 9;
            }

        }
        Console.WriteLine("You guessed it!");
        
    }
}