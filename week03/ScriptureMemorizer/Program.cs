using System;


class Program
{
    static string MakeChoice()
    {
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string _choices = Console.ReadLine();
        return _choices;
    }


    static void Main(string[] args)
    {
        bool _choice = true;
        string _text = "Trust in the Lord with all thine heart and lean not unto thine own\nunderstanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Reference _reference = new Reference("Proverbs",3,5,6);
        Scripture _scripture = new Scripture(_text);        
        while (_choice == true)
        {
            Console.Clear();
            Console.WriteLine(_reference.GetDisplayTextMultiple());
            Console.WriteLine(_scripture.GetDisplayText());
            Console.WriteLine();
            string _choices = MakeChoice();
            if (_choices == "quit")
            {
                _choice = false;

            }


        }

        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    }
}