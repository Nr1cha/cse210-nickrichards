using System;
using System.IO;

class Program
{
    static List<Prompt> generatePrompts()
    {
        // List = journalQuestions
        List<Prompt> journalQuestions = new List<Prompt>();

        // Questions
        Prompt questionOne = new Prompt();
        questionOne._userPrompt = "Write about what happened today that was fun";
        journalQuestions.Add(questionOne);

        Prompt questionTwo = new Prompt();
        questionTwo._userPrompt = "what was something that your wife did that was great!";
        journalQuestions.Add(questionTwo);

        Prompt questionThree = new Prompt();
        questionThree._userPrompt = "write about your dad";
        journalQuestions.Add(questionThree);

        Prompt questionFour = new Prompt();
        questionFour._userPrompt = "write about your evening.";
        journalQuestions.Add(questionFour);

        Prompt questionFive = new Prompt();
        questionFive._userPrompt = "Who was the most interesting person I interacted with today?";
        journalQuestions.Add(questionFive);

        Prompt questionSix = new Prompt();
        questionSix._userPrompt = "What was the best part of my day?";
        journalQuestions.Add(questionSix);

        Prompt questionSeven = new Prompt();
        questionSeven._userPrompt = "How did I see the hand of the Lord in my life today?";
        journalQuestions.Add(questionSeven);

        Prompt questionEight = new Prompt();
        questionEight._userPrompt = "What was the strongest emotion I felt today?";
        journalQuestions.Add(questionEight);

        Prompt questionNine = new Prompt();
        questionNine._userPrompt = "If I had one thing I could do over today, what would it be?";
        journalQuestions.Add(questionNine);


        return journalQuestions;
    }
    static void Main(string[] args)
    {
        int userInt; // this is what the user types in that is being used in while argument
        List<Prompt> prompts = generatePrompts();
        Random rnd = new Random(); //initializing the random method in C#

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
                prompts[rnd.Next(0, prompts.Count)].Display();
                string question1Answer = Console.ReadLine(); //assigning to a variable for question 1

                Entry entry = new Entry(); //invoking Entry class to use here as an instance
                entry._userInput = question1Answer;
                entry._date = new DateOnly().ToString();

                // TODO: Add the current Prompt to your entry
                // TODO: Inside of your entry class, add the prompt to your display function
                Console.Write("entry: ");
                Console.Write(entry.Display());

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