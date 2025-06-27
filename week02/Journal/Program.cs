using System;
class Program
{
    static int DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Save");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Display");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    static void Main(string[] args)
    {
        bool makeChoice = true;


        Console.WriteLine("Welcome to the Journal program!");
        Jorunal journal = new Jorunal();
        while (makeChoice == true)
        {
            int choice = DisplayMenu();

            if (choice == 1)
            {

                journal.AddEntry();

            }
            else if (choice == 2)
            {
                //journal.SaveToFile("entries.txt");
                journal.SaveToFile("entries.csv");
            }
            else if (choice == 3)
            {
                //journal.LoadFromFile("entries.txt");
                journal.LoadFromFile("entries.csv");
            }
            else if (choice == 4)
            {
                journal.DisplayAll();
            }
            else if (choice == 5)
            {
                makeChoice = false;
            }
        }

    }
}

//https://www.bing.com/search?pglt=297&q=how+do+you+print+everything+in+a+list+in+c%23&cvid=9c8e63d792b048fd92521a649b0e0466&gs_lcrp=EgRlZGdlKgYIABBFGDkyBggAEEUYOTIGCAEQABhAMgYIAhAAGEAyBggDEAAYQDIGCAQQABhAMgYIBRAAGEAyBggGEAAYQDIGCAcQABhAMgYICBAAGEDSAQoxMDIwODZqMGoxqAIAsAIA&FORM=ANNTA1&PC=U531
// This is the search perameter I used to help with some of my code
// I believe I was able to save and load my code from a csv file, this is the creativity part I did.