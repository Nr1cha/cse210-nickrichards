using System;

class Program
{

    static void Main(string[] args)
    {
        // variables 
        string staticScripture = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day. ";
        int userSelection;
        string userInputBookName;
        int userInputChaptNum;
        int userInputVerseStartNum;
        int userInputVerseEndNum;
        string userInputScripture;
        Reference displayRef = new Reference("Alma", 37, 37);
        Scripture currentScripture = new Scripture(displayRef, staticScripture); // invoking the scripture class to take staticScripture



        // OUTPUT
        // todo get user input
        Console.Clear();

        Console.WriteLine("Welcome to the Scripture Memorizor program!");
        // todo ask if user whants to select their own scripture. 

        Console.WriteLine("Do you want to have me show you a scripture or would you like to provide your own scripture?");
        Console.WriteLine("Press 1 for viewing a scripture.");
        Console.WriteLine("Press 2 for making your own.");

        userSelection = int.Parse(Console.ReadLine());

        if (userSelection == 2)
        {
            Console.Clear();

            Console.WriteLine("Please type in the name of a scripture book. e.g. 'alma, nephi, etc..'");
            userInputBookName = Console.ReadLine();

            Console.WriteLine("Please type in a chapter number:");
            userInputChaptNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the start verse number:");
            userInputVerseStartNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Now provide the ending verse number (if you only want one verse, please enter the start verse again):");
            userInputVerseEndNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Lastly, type out your scripture verse then press '[ENTER]'");
            userInputScripture = Console.ReadLine();

            Reference userReference;
            if (userInputVerseStartNum == userInputVerseEndNum)
            {
                userReference = new Reference(userInputBookName, userInputChaptNum, userInputVerseStartNum);
            }
            else
            {

                userReference = new Reference(userInputBookName, userInputChaptNum, userInputVerseStartNum, userInputVerseEndNum);// just the reference

            }

            currentScripture = new Scripture(userReference, userInputScripture);//scripture
        }
        else
        {
            currentScripture = new Scripture(displayRef, staticScripture);
        }

        Console.Clear();
        currentScripture.DisplayScripture();

        // USER INPUT FOR TYPING TO THE CONSOLE
        string userInput;
        do
        {
            Console.WriteLine("");
            Console.WriteLine("\nPress ENTER to make words disappear or type 'quit' at anytime to finish: \n");
            userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                Console.WriteLine("Thanks for reading!");
                System.Environment.Exit(0);
            }
            else if (currentScripture.ModifiedScriptureList.Count == 0)
            {
                System.Environment.Exit(0);
            }
            else if (userInput == "") // if its ENTER
            {
                currentScripture.RemoveRandomWords(5); // remove a word when ENTER is pressed
                Console.Clear();
                currentScripture.DisplayScripture(); // this shows the scripture
            }
        } while (userInput != "quit");

    }
}