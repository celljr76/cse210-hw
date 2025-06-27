using System.IO;

public class Jorunal
{
    public List<string> _entries = new List<string>();
    Entry entry = new Entry();
    Prompts prompts = new Prompts();
    DateTime theCurrentDate = DateTime.Now;
    public void AddEntry()

    {
        string _promptText1 = prompts.GetRandomPrompt();
        entry._promptText = _promptText1;
        entry._date = theCurrentDate.ToShortDateString();
        Console.WriteLine(_promptText1);
        Console.Write("> ");
        entry._entryText = Console.ReadLine();
        _entries.Add(entry._promptText);
        _entries.Add(entry._entryText);
        _entries.Add(entry._date);
    }


    public void DisplayAll()
    {
        foreach (string entries in _entries)
        {
            Console.WriteLine(entries);
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        foreach (string entries in _entries)
            {
                outputFile.WriteLine(entries);
            }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string entries in lines)
        {
            _entries.Add(entries);
        }

    }
}