using System;

public class Assignment
{
    // Attributes here
    private string _activityName;
    private string _description;
    protected int _duration;

    // Constructor here
    public Assignment(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    // Methods here
    public void DisplayStart()
    {
        Console.WriteLine($"Wlecome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());
    }

    public void DisplayEnd()
    {
        Console.WriteLine("Well done!!");
        SpinPause();
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName} Activity.");
        SpinPause();
    }

    public void SpinPause()
    {
        List<string> loadAnimation = new List<string>();
        loadAnimation.Add("\\");
        loadAnimation.Add("|");
        loadAnimation.Add("/");
        loadAnimation.Add("-");
        loadAnimation.Add("\\");
        loadAnimation.Add("|");
        loadAnimation.Add("/");
        loadAnimation.Add("|");
        int cycles = 0;
        while (cycles < 4)
        {
            foreach (string s in loadAnimation)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
            cycles ++;
        }
    }

    public void CountdownPause()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }
}