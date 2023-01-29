using System;

public class PromptGenerator
{
    // List needed variables here
    // Create a list of prompts
    public List<String> _prompts = new List<String>();

    // Write prompts stored as individual variables
    public string _prompt1;
    public string _prompt2;
    public string _prompt3;
    public string _prompt4;
    public string _prompt5;

    // List needed functions here
    public string GeneratePrompt()
    {
        Random R = new Random();
        int index = R.Next(0, _prompts.Count());
        string question = _prompts.ElementAt(index);
        
        return question;
    }
}