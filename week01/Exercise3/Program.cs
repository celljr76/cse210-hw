using System;

class Program
{
    static void Main(string[] args)
    {
        int var = 8;
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