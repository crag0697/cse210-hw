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
            Console.WriteLine("4. Save");

            Console.WriteLine("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Breathing Breathing = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

                Breathing.DisplayStart();
                Breathing.RunBreathing();
                Breathing.DisplayEnd();
            }














        }
        while (choice != 4);
    }
}