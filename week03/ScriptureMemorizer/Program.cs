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
        Reference _reference = new Reference();
        Scripture _scripture = new Scripture();
        Word _word = new Word();
        
        while (_choice == true)
        {
            Console.Clear();
            _reference.ReferenceMultiple("Proverbs", 3, 5, 6);
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