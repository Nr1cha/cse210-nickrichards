using System;

class Program
{
    Reference displayRef = new Reference();
    static void Main(string[] args)
    {
        // variables 
        string refScript = "Alma 37: 37";
        string hardScripture = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day. ";
        // OUTPUT
        Console.Clear();
        Console.WriteLine($"{refScript}");
        Console.WriteLine($"{hardScripture} \n");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        // USER INPUT FOR TYPING TO THE CONSOLE
        string userInput = Console.ReadLine();;
        if (userInput == "quit")
        {
            Console.WriteLine("thanks for playing");
            System.Environment.Exit(0);
        }
    }
}