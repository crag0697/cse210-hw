using System;

public class MathAssignment : Assignment
{
    // Variables here
    private string _textbookSection;
    private string _problems;

    // Constructor here
    public MathAssignment( string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Methods here
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}