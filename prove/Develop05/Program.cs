using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    
    static void Main(string[] args)
    {
        int userInput;
        int userInput2;
        ManageGoals bigGoalList = new ManageGoals();

        do
        {
            Console.Clear();
            Console.WriteLine($"You have {bigGoalList.DisplayPoints()} points.");
            Console.WriteLine("");
            Console.WriteLine($"{bigGoalList.showCompletedGoals()}");
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
                // common questions
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create?");
                userInput2 = int.Parse(Console.ReadLine());

                // sub-questions
                Console.WriteLine("");
                Console.WriteLine("What is the name of the goal? ");
                string goalName = Console.ReadLine(); 
                Console.WriteLine("Enter goal description:");
                string goalDescription = Console.ReadLine(); 
                Console.WriteLine("What is the amount of points associated with this goal? ");
                int totalPoints = int.Parse(Console.ReadLine()); 

                if (userInput2 == 1)
                {
                    Goal newGoal = new SimpleGoal(goalName, goalDescription, totalPoints);
                    bigGoalList.AddGoalsToList(newGoal);

                }
                else if (userInput2 == 2)
                {
                    Goal newGoal = new EternalGoal(goalName, goalDescription, totalPoints);
                    bigGoalList.AddGoalsToList(newGoal);
                }
                else if (userInput2 == 3)
                {

                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int bonusNum = int.Parse(Console.ReadLine());
                    Console.Write($"What is the bonus for accomplishing it {bonusNum} times? ");
                    int bonusScore = int.Parse(Console.ReadLine());
                    Goal newGoal = new CheckListGoal(goalName, goalDescription, totalPoints, bonusNum, bonusScore);
                    bigGoalList.AddGoalsToList(newGoal);
                    Console.WriteLine("Goal added successfully");
                    Console.ReadKey();
                }
                
            }
            else if (userInput == 2) //* work on listing new goals
            {
                Console.Clear();
                Console.WriteLine("Goals:");
                Console.WriteLine(bigGoalList.DisplayGoals());
                Console.ReadKey();

            }
            else if (userInput == 3)
            {
                Console.Clear();
                Console.WriteLine("Enter a file name to save the goals: ");
                string userFile = Console.ReadLine();
                bigGoalList.SaveAllGoals(userFile);
                Thread.Sleep(1500);

            }
            else if (userInput == 4)
            {
                Console.Clear();
                Console.WriteLine("Please provide the name of the filename");
                string userLoadFile = Console.ReadLine();
                bigGoalList.LoadGoals(userLoadFile);
                Console.ReadKey();

            }
            else if (userInput == 5)
            {
                Console.Clear();
                Console.WriteLine("The Goals are: ");
                Console.WriteLine(bigGoalList.DisplayGoalNames());
                Console.Write("Which goal did you accomplish? ");
                int userSelection;
                userSelection = int.Parse(Console.ReadLine());
                int currentPoints = bigGoalList.RecordEvent(userSelection);
                Console.WriteLine($"Congratulations, you have earned {currentPoints} points.");
                Console.WriteLine($"You now have {bigGoalList.DisplayPoints()} total points");

                Console.ReadKey();
            }

        }
        while (userInput != 6);
    }
}