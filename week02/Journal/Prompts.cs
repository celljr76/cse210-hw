public class Prompts
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("Did you do any good today?");
        _prompts.Add("Did you have a meaningful conversation with anyone?");
        _prompts.Add("Did you talk to your parents today?");
        _prompts.Add("Did you talk to your grandparents today?");
        _prompts.Add("What was the best part of my day?");

        Random randomgenerator = new Random();
        int randomPrompt = randomgenerator.Next(1, _prompts.Count + 1);
        string _prompt = _prompts[randomPrompt];
        return _prompt;

    }

    


}