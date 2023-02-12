using System;

public class Scripture
{
    // Place variables here
    // Reference variable type is the reference class itself
    private string _reference;
    private List<string> _words;

    // Place Methods here
    public Scripture(string reference, string text)
    {
        _reference = reference;
        string[] textArray = text.Split(" ");
        _words = textArray.ToList();
    }

    public List<string> getWords()
    {
        return _words;
    }
    public string ListToString()
    {
        string[] arrayText = _words.ToArray();
        return string.Join(" ", arrayText);
    }

    public bool IsCompletelyHidden()
    {
        bool isFinished = true;
        do
        {   int i = 0;
            if (_words[i].Contains('_'))
            {
                isFinished = true;
                i++;
            }
            else
            {
                isFinished = false;
            }

        }
        while (isFinished == true);

        return isFinished;
    }
    public void DisplayScripture(string text)
    {
        Console.WriteLine($"{_reference} {text}");
    }
    public void DisplayScriptureMultiple(string text)
    {
        Console.WriteLine($"{_reference} {text}");
    }
}