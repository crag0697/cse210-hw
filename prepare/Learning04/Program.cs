using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Craig Mortensen", "History");
        Console.WriteLine(test.GetSummary());

        MathAssignment test2 = new MathAssignment("Craig Mortensen", "Math", "Differential Equations", "10-23 odds");
        Console.WriteLine(test2.GetHomeworkList());
        Console.WriteLine(test2.GetSummary());

        WritingAssignment test3 = new WritingAssignment("Craig Mortensen", "History", "Slavery in the South");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());
    }
}