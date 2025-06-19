using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = squareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            return Name;

        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        static int squareNumber(int number)
        {
            int numbers = number * number;

            return numbers;
        }
        static void DisplayResult(string userName, int userNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {userNumber}");
        }
    }
}