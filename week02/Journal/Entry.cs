using System.ComponentModel;
using System.Text.Encodings.Web;

public class Entry

{
    public string _date = "";
    public string _entryText = "";
    public string _promptText = "";
    //public string GetEntry()
    //{
    //string _promptText = _prompts.GetRandomPrompt();
    //List<string> listEntry = new List<string>();
    //Console.WriteLine(_promptText);
    //Console.Write("> ");
    //string _entryText = Console.ReadLine();
    //listEntry.Add(_promptText);
    //listEntry.Add(_entryText);
    //listEntry.Add(_date);
    //return _entryText;
    //}

    public void Display()
    {
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
        Console.WriteLine(_date);
    }



}
        //string _promptText = _prompts.GetRandomPrompt();
        //List<string> listEntry = new List<string>();
        //listEntry.Add(_promptText);
        //listEntry.Add(_date);

        //foreach (string _text in listEntry)
        //{
            //Console.WriteLine(_text);
        //}