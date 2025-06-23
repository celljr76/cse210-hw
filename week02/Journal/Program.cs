using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

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
        List<string> _entries = new List<string>();
        //Console.WriteLine("Hello World! This is the Journal Project.");
        bool makeChoice = true;


        Console.WriteLine("Welcome to the Journal program!");

        while (makeChoice == true)
        {
            
           int choice = DisplayMenu();
            if (choice == 1)
            {
                Console.WriteLine("I love you");
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {
                
            }
            else if (choice == 5)
            {
                makeChoice = false;
            }
        }

    }
}