using System;

public class Reflecting : Assignment
{
    // Attributes here
    private List<string> _prompts;
    private List<string> _questions;
    private string _answer;

    // Constructor here
    public Reflecting(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }

    // Methods here
    public void RunReflecting()
    {

    }

    public string GetPrompt()
    {
        return prompt;
    }

    public string GetQuestion()
    {
        return question;
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }

    public string GetAnswer()
    {
        return answer;
    }
}