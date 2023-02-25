using System;

public class Reflecting : Assignment
{
    // Attributes here
    private List<string> _prompts;
    private List<string> _questions;
    private string _answer;

    // Constructor here
    public Reflecting(string activityName, string description) : base(activityName, description)
    {
        
    }

    // Methods here
    public List<string> SetPrompts()
    {
        string prompt1 = "---Think of a time when you stood up for someone else.---";
        string prompt2 = "---Think of a time when you did something really difficult.---";
        string prompt3 = "---Think of a time when you helped someone in need.---";
        string prompt4 = "---Think of a time when you did something truly selfless.---";

        var prompts = new List<string>();
        prompts.Add(prompt1);
        prompts.Add(prompt2);
        prompts.Add(prompt3);
        prompts.Add(prompt4);

        return prompts;
    }

    public List<string> SetQuestions()
    {
        string question1 = "Why was this experience meaningful to you?  ";
        string question2 = "How did you feel when it was complete?  ";
        string question3 = "What is your favorite thing about this experience?  ";
        string question4 = "What did you learn about yourself through this experience?  ";
        string question5 = "Have you ever done anything like this before?  ";
        string question6 = "How did you get started?  ";
        string question7 = "What made this time different than other times when you were not as successful?  ";
        string question8 = "How can you keep this experience in mind in the future?  ";

        var questions = new List<string>();
        questions.Add(question1);
        questions.Add(question2);
        questions.Add(question3);
        questions.Add(question4);
        questions.Add(question5);
        questions.Add(question6);
        questions.Add(question7);
        questions.Add(question8);

        return questions;
    }
    public void RunReflecting()
    {
        Console.WriteLine("Get Ready...");
        SpinPause();
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");

        _prompts = SetPrompts();
        string prompt = GetPrompt();
        Console.WriteLine($"{prompt}");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine($"You may begin in: ");
        CountdownPause();

        _questions = SetQuestions();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        while (currentTime < endTime)
        {
            string question = GetQuestion();
            Console.Write($"> {question}");
            SpinPause();
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }

    public string GetPrompt()
    {
        Random R = new Random();
        int index = R.Next(0, 4);
        string prompt = _prompts.ElementAt(index);
        return prompt;
    }

    public string GetQuestion()
    {
        Random S = new Random();
        int index = S.Next(0, 8);
        string question = _questions.ElementAt(index);
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetQuestion());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetQuestion());
    }

    public void GetAnswer()
    {
        _answer = Console.ReadLine();
    }
}