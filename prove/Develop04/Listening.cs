using System;

public class Listening : Assignment
{
    // Attributes here
    private List<string> _prompts;
    private List<string> _answers;
    private int _answerTotal;

    // Constructor here
    public Listening(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }

    // Methods here
    public void RunListen()
    {

    }

    public string GetPrompt()
    {
        return prompt;
    }

    public void DisplayPrompt()
    {

    }

    public string GetAnswer()
    {
        return answer;
    }

    public void DisplayTotal()
    {

    }
}