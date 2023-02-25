using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options");
        int choice = 0;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Breathing Breathing = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

                Breathing.DisplayStart();
                Breathing.RunBreathing();
                Breathing.DisplayEnd();
            }

            else if (choice == 2)
            {
                Reflecting Reflecting = new Reflecting("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                Reflecting.DisplayStart();
                Reflecting.RunReflecting();
                Reflecting.DisplayEnd();
            }

            else if (choice == 3)
            {
                Listening Listening = new Listening("Listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                Listening.DisplayStart();
                Listening.RunListen();
                Listening.DisplayEnd();
            }














        }
        while (choice != 4);
    }
}