using System;

public class PromptGenerator
{
    // List needed variables here
    // Create a list of prompts
    public List<String> _prompts = new List<String>();

    // Write prompts stored as individual variables
    public string prompt1 = "Describe someone interesting you met today!";
    public string prompt2 = "What was the best thing that happened today?";
    public string prompt3 = "What was something you accomplished today?";
    public string prompt4 = "What was the weather like today? Did you enjoy it?";
    public string prompt5 = "What was your favorite thing you ate today?";

    // List needed functions here
    public string GeneratePrompt()
    {
        Random R = new Random();
        int index = R.Next(0, 4);
        string question = _prompts.ElementAt(index);
        
        return question;
    }
}