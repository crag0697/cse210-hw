using System;

public class Breathing : Assignment
{
    // Atributes here

    // Constructor here
    public Breathing(string activityName, string description) : base(activityName, description)
    {

    }

    // Methods here
    public void RunBreathing()
    {
        Console.WriteLine("Get Ready...");
        SpinPause();
        Console.WriteLine();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        Thread.Sleep(3000);

        while (currentTime < endTime)
        {
            DisplayIn();
            DisplayOut();
            Console.WriteLine();

            currentTime = DateTime.Now;
        }
    }

    public void DisplayIn()
    {
        Console.WriteLine("Breathe in...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }

    public void DisplayOut()
    {
        Console.WriteLine("Breathe out...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }
}