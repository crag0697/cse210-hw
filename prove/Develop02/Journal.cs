using System;
using System.IO;
public class Journal
{
    // List needed variables here
    // The journal needs to store a list of entry objects
    public List<Entry> _entries = new List<Entry>();

    

    // List needed functions here
    public Entry AddEntry()
    {
        PromptGenerator prompts = new PromptGenerator();
        prompts._prompts.Add(prompts.prompt1);
        prompts._prompts.Add(prompts.prompt2);
        prompts._prompts.Add(prompts.prompt3);
        prompts._prompts.Add(prompts.prompt4);
        prompts._prompts.Add(prompts.prompt5);

        Entry newEntry = new Entry();
    
        newEntry._prompt = prompts.GeneratePrompt();
        Console.WriteLine(newEntry._prompt);
        newEntry._response = Console.ReadLine();
        newEntry._date = System.DateTime.Now.ToString("MM.dd.yyyy");

        return newEntry;
    }
    
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayJournalDetails();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        using (StreamWriter savedFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                savedFile.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

    }
}