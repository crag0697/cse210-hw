using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal Journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry entry = Journal.AddEntry();
                Journal._entries.Add(entry);

            }

            else if (choice == 2)
            {
                Journal.DisplayEntries();
            }

            else if (choice == 3)
            {
                Journal.LoadFromFile();
            }

            else if (choice == 4)
            {
                Journal.SaveToFile();
            }
        }
        while (choice != 5);

        
    }
}