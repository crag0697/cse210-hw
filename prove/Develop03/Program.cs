using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the reference for a single verse scripture and define the text of the verse
        // Create an assembled reference to pass to the scripture class for displaying
        Reference johnRef = new Reference("John", 3, 16);
        string formattedJohnRef = johnRef.CreateSingleVerseRef();
        
        // Create an instance of Scripture passing the assembled reference and text string
        // to the Scripture constructor
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture john = new Scripture(formattedJohnRef, scriptureText);



//----------------------------------------------------------------------------------------------------------------------------//

        // Create the reference for a multiple verse passage and define the text
        // Create an assempled reference to pass tot he scripture class for displaying
        Reference jamesRef = new Reference("1 James", 2, 17, 18);
        string formattedJamesRef = jamesRef.CreateMultipleVerseRef();

        // Create an instance of Scripture passing the assembled reference and text
        // to the Scripture constructor
        string scriptureTextMultiple = "Even so faith, if it hath not works, is dead, being alone. Yea, a man may say, Thou hast faith, and I have works: shew me thy faith without thy works, and I will shew thee my faith by my works.";
        Scripture james = new Scripture(formattedJamesRef, scriptureTextMultiple);

//--------------------------------------------------------------------------------------------------------------------------------//

    string confirm = "";
    do
    {
    if (john.IsCompletelyHidden() == false && confirm != "quit")
    {
        john.DisplayScripture(scriptureText);
        // james.DisplayScriptureMultiple(scriptureTextMultiple);

        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type quit to finish:");
        confirm = Console.ReadLine();

        
        for (int i = 0; i < 3; i++)
        {
            bool looking = true;
            do
            {
                int random_index = new Random().Next(0, john.getWords().Count - 1);
                string wordToHide = john.getWords()[random_index];

                Word word = new Word(false, wordToHide);
                bool status = word.GetWordStatus();

                if (status == false && word.getWord() != ",")
                {
                    string hidden = word.HideWord();
                    wordToHide = hidden;
                    looking = false;
                    john.getWords()[random_index] = wordToHide;
                    scriptureText = john.ListToString();
                }
            }
            while (looking == true);
            
        }
        }





    }
    while (confirm != "quit");
    }
}