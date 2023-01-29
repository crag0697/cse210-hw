using System;

class Program
{
    static void Main(string[] args)
    {
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
                Journal Journal = new Journal();
                Journal.AddEntry();
            }

            else if (choice == 2)
            {
                Journal Journal = new Journal();
                Journal.DisplayEntries();
            }

            else if (choice == 3)
            {
                Console.WriteLine("Load");
            }

            else if (choice == 4)
            {
                Console.WriteLine("Save");
            }
        }
        while (choice != 5);

        
    }
}