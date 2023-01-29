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
                // Generate a list of prompts
                

                string prompt1 = "Describe someone interesting you met today!";
                string prompt2 = "What was the best thing that happened today?";
                string prompt3 = "What was something you accomplished today?";
                string prompt4 = "What was the weather like today? Did you enjoy it?";
                string prompt5 = "What was your favorite thing you ate today?";

                PromptGenerator newPrompt = new PromptGenerator();
                // Add the prompts to the list in the PromptGenerator class
                newPrompt._prompts.Add(prompt1);
                newPrompt._prompts.Add(prompt2);
                newPrompt._prompts.Add(prompt3);
                newPrompt._prompts.Add(prompt4);
                newPrompt._prompts.Add(prompt5);

                // Choose a random entry from the new list object
                string entryQuestion = newPrompt.GeneratePrompt();
                
                Entry newEntry = new Entry();
                newEntry._prompt = entryQuestion;
                newEntry._response = Console.ReadLine();
                newEntry._date = System.DateTime.Now.ToString("MM.dd.yyyy");
            }

            else if (choice == 2)
            {
                Console.WriteLine("Test 2");
            }

            else if (choice == 3)
            {
                Console.WriteLine("Test 3");
            }

            else if (choice == 4)
            {
                Console.WriteLine("Test 4");
            }
        }
        while (choice != 5);

        
    }
}