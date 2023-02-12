using System;

public class Word
{
    // Place variables here
    private bool _isHidden;
    private string _word;

    // Place methods here
    public Word(bool hidden, string word)
    {
        _isHidden = hidden;
        _word = word;
    }
    public string getWord()
    {
        return _word;
    }

    public bool GetWordStatus()
    {
        return _isHidden;
    }

    public string GetDisplayedText()
    {
        return _word;
    }
    public string HideWord()
    {
        char[] brokenWord = _word.ToCharArray();
        for (int i = 0; i <= _word.Length - 1; i++)
        {
            brokenWord[i] = '_';
        }
        string newWord = string.Join(" ", brokenWord);
        return newWord;
    }
    public bool IsWordHidden()
    {
        bool state = false;
        char letter = _word[0];

        if (letter == '_')
        {
            state = true;
        }
        else
        {
            state = false;
        }
        
        return state;
    }
}   