using System;

class Program
{
    static void Main(string[] args)
    {

        // int totalPoints;
        int userInput;
        string userFile;
        List<Goal> _goalList = new List<Goal>();
        ManageGoals bigGoalList = new ManageGoals(userFile);

        do
        {
            Console.Clear();
            Console.WriteLine($"You have {bigGoalList.DisplayPoints(0)} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.Clear();
                Console.WriteLine("What is the name of the goal? ");
                string goalName = Console.ReadLine();
                Console.WriteLine("Enter goal description:");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("How many points is it worth? ");
                int totalPoints = int.Parse(Console.ReadLine());
                Goal newGoal = new Goal(string goalName, string goalDescription, int totalPoints);
                bigGoalList.AddGoalsToList(newGoal);
                Console.WriteLine("Goal added successfully");
                Console.ReadKey();
            }
            else if (userInput == 2)
            {
                Console.Clear();
                Console.WriteLine("you selected 2 as your option");
            }
            else if (userInput == 3)
            {
                Console.Clear();
                Console.WriteLine("you selected 3 as your option");
            }
            else if (userInput == 4)
            {
                Console.Clear();
                Console.WriteLine("you selected 4 as your option");
            }
            else if (userInput == 5)
            {
                Console.Clear();
                Console.WriteLine("you selected 5 as your option");
                Thread.Sleep(1500);
            }

        }
        while (userInput != 6);
        return;



    }
}