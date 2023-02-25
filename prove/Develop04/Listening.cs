using System;

public class Listening : Assignment
{
    // Attributes here
    private List<string> _prompts;

    private List<string> _answers;

    // Constructor here
    public Listening(string activityName, string description) : base(activityName, description)
    {

    }

    // Methods here
    public void RunListen()
    {
        Console.WriteLine("Get Ready...");
        SpinPause();
        Console.WriteLine();

        Console.WriteLine("List as many responses as you can to the following prompt: ");

        _prompts = SetPrompts();
        string prompt = GetPrompt();
        Console.WriteLine($"{prompt}");

        Console.WriteLine($"You may begin in: ");
        CountdownPause();

        _answers = GetAnswers();
        DisplayTotal();
        
    }

    public List<string> SetPrompts()
    {
        string prompt1 = "---Who are people that you appreciate?---";
        string prompt2 = "---What are personal strengths of yours?---";
        string prompt3 = "---Who are people that you have helped this week?---";
        string prompt4 = "---Who are some of your personal heroes?---";

        var prompts = new List<string>();
        prompts.Add(prompt1);
        prompts.Add(prompt2);
        prompts.Add(prompt3);
        prompts.Add(prompt4);

        return prompts;
    }

    public string GetPrompt()
    {
        Random R = new Random();
        int index = R.Next(0, 4);
        string prompt = _prompts.ElementAt(index);
        return prompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetPrompt());
    }

    public List<string> GetAnswers()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        var answers = new List<string>();
        while (currentTime < endTime)
        {
            Console.Write($">");
            string answer = Console.ReadLine();
            answers.Add(answer);
            currentTime = DateTime.Now;
        }
        return answers;  
    }

    public void DisplayTotal()
    {
        Console.WriteLine($"You listed {_answers.Count} items!");
    }
}