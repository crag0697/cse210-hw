using System;

public class Reference 
{
    // Place all variables here
    private string _book;
    private int _chapter;
    private int _startVerse;
    public int _endVerse;

    // Place behaviors below here
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string CreateSingleVerseRef()
    {
        string reference = $"{_book} {_chapter}:{_startVerse}";
        return reference;
    }
    public string CreateMultipleVerseRef()
    {
        string reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        return reference;
    }



}