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
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");

            Console.WriteLine("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
        }
        while (choice != 4);
    }
}