using System;

public class Journal
{
    // List needed variables here
    // The journal needs to store a list of entry objects
    public List<Entry> _entries = new List<Entry>();

    

    // List needed functions here
    public void AddEntry()
    {
        PromptGenerator prompts = new PromptGenerator();
        prompts.CompilePromptList();
        Journal newJournal = new Journal();
        Entry newEntry = new Entry();
    
        string question = prompts.GeneratePrompt();
        Console.WriteLine(question);
        newEntry._response = Console.ReadLine();
        newEntry._date = System.DateTime.Now.ToString("MM.dd.yyyy");
        
        newJournal._entries.Add(newEntry);

    }
    
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }
}