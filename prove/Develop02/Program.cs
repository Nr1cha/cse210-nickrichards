using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int userInt; // this is what the user types in that is being used in while argument
        PromptGenerator generator = new PromptGenerator();


        Console.WriteLine("Welcome to you're digital journal.");
        Journal userJournal = new Journal(); //invoking Journal class to use here as an instance

        // options to select
        do
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Quit Program");
            Console.WriteLine("What would you like to do?");

            userInt = int.Parse(Console.ReadLine()); //getting what the user typed in and assigning it to a variable


            if (userInt == 1) // using what the user typed in
            {
                string prompt = generator.getQuestion();
                Console.WriteLine(prompt);
                string question1Answer = Console.ReadLine(); //assigning to a variable for question 1

                Entry entry = new Entry(); //invoking Entry class to use here as an instance
                entry._userInput = question1Answer;
                entry._date = DateTime.Now.ToString();
                entry._prompt = prompt;

                Console.Write("Entry: ");
                Console.WriteLine(entry.Display());

                userJournal._entries.Add(entry);
                
            }
            else if (userInt == 2)
            {
                Console.WriteLine("Here is your journal...");
                string output = userJournal.Display();
                Console.WriteLine(output);
             
            }
            else if (userInt == 3)
            {
                Console.WriteLine("What is the filename to load? ");
               
            }
            else if (userInt == 4)
            {
                Console.WriteLine("What is the filename? ");
               
            }
        }
        while (userInt != 5);


        // Console.WriteLine("Hello Develop02 World!");
        // Entry entry = new Entry();
        // entry._date = "today";
        // Console.WriteLine(entry.Display());

        // Entry entry2 = new Entry();
        // entry2._date = "tomorrow";
        // Console.WriteLine(entry2.Display());

    }
}