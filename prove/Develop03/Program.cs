using System;

class Program
{

    static void Main(string[] args)
    {
        // variables 
        string staticScripture = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day. ";
        string userInputBookName;
        int userInputChaptNum;
        int userInputVerseStartNum;
        int userInputVerseEndNum;
        string userInputScripture;

        Reference displayRef = new Reference("Alma", 37, 37, 89);
        Scripture currentScripture = new Scripture(displayRef, staticScripture); // invoking the scripture class to take staticScripture

        // OUTPUT
        // todo get user input
        Console.Write("Welcome to the Scripture Memorizor program!");
        Console.WriteLine("Please type in the name of a scripture book. e.g. 'alma, nephi, etc..'");
        userInputBookName = Console.ReadLine();

        Console.WriteLine("Please type in a single chapter number:");
        userInputChaptNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please provide the start verse number:");
        userInputVerseStartNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Now provide the ending verse number:");
        userInputVerseEndNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Lastly, type out your scripture verse then press '[ENTER]'");
        userInputScripture = Console.ReadLine();





        Console.Clear();
        currentScripture.DisplayScripture();


        // USER INPUT FOR TYPING TO THE CONSOLE
        string userInput;
        do
        {
            Console.WriteLine("");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: \n");
            userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                Console.WriteLine("Thanks for reading!");
                System.Environment.Exit(0);
            }
            else if (currentScripture.ModifiedStringThing.Count == 0)
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