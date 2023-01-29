using System;

// Create the class
public class Entry
{
    // List needed variables here
    public string _prompt;
    public string _response;
    public string _date;
    
    // List needed functions here
    public void DisplayJournalDetails()
    {
        Console.WriteLine($"{_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
    }
}