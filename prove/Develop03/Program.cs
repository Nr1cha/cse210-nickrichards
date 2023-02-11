using System;

class Program
{
    Reference displayRef = new Reference();
    static void Main(string[] args)
    {
        // variables 
        string staticReference = "Alma 37: 37";
        string staticScripture = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day. ";
        Scripture currentScripture = new Scripture(staticScripture); // invoking the scripture class to take staticScripture

        // OUTPUT
        Console.Clear();
        Console.WriteLine($"{staticReference}");
        currentScripture.DisplayScripture();


        // USER INPUT FOR TYPING TO THE CONSOLE
        string userInput;
        do
        {
            Console.WriteLine("");
            Console.WriteLine("\n Press enter to continue or type 'quit' to finish: \n");
            userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                Console.WriteLine("thanks for playing");
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
                Console.WriteLine($"{staticReference}");
                currentScripture.DisplayScripture(); // this shows the scripture
            }
        } while (userInput != "quit");
    }
}