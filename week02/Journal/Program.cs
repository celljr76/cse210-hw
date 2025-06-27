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
        //Console.WriteLine("Hello World! This is the Journal Project.");
        bool makeChoice = true;


        Console.WriteLine("Welcome to the Journal program!");
        Entry entry = new Entry();
        Prompts prompts = new Prompts();
        Jorunal journal = new Jorunal();
        DateTime theCurrentDate = DateTime.Now;

        while (makeChoice == true)
        {
            int choice = DisplayMenu();
            string _promptText1 = prompts.GetRandomPrompt();

            if (choice == 1)
            {
                entry._promptText = _promptText1;
                entry._date = theCurrentDate.ToShortDateString();
                //Console.WriteLine(_promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();

            }
            else if (choice == 2)
            {
                journal.SaveToFile("entries.txt");
            }
            else if (choice == 3)
            {
                journal.LoadFromFile("entries.txt");
            }
            else if (choice == 4)
            {
                entry.Display();
            }
            else if (choice == 5)
            {
                makeChoice = false;
            }
        }

    }
}