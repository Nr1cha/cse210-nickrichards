using System;

class Program
{
    static void Main(string[] args)
    {

        // int totalPoints;
        int userInput;
        int userInput2;
        // string userFile;
        List<Goal> _goalList = new List<Goal>();
        // ManageGoals bigGoalList = new ManageGoals(userFile);

        do
        {
            Console.Clear();
            // Console.WriteLine($"You have {bigGoalList.DisplayPoints(0)} points.");
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
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create?");
                userInput2 = int.Parse(Console.ReadLine());

                if (userInput2 == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("What is the name of the goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Enter goal description:");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int totalPoints = int.Parse(Console.ReadLine());
                }
                else if (userInput2 == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("What is the name of the goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Enter goal description:");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int totalPoints = int.Parse(Console.ReadLine());
                }
                else if (userInput2 == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("What is the name of the goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Enter goal description:");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int totalPoints = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int bonusNum = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusScore = int.Parse(Console.ReadLine());

                }
                // Goal newGoal = new Goal(string goalName, string goalDescription, int totalPoints);
                // bigGoalList.AddGoalsToList(newGoal);
                // Console.WriteLine("Goal added successfully");
                // Console.ReadKey();
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