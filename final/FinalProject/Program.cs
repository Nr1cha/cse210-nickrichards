using System;
using System.Threading;
using static System.Console;

class Program
{

    static SharedCharacterClasses QuestionsForClass(Type clazz)
    {
        Clear();
        // * work on the input for the name, race and background
        WriteLine($"What is your Characters name?");
        string charName = ReadLine();

        WriteLine($"What is your Characters race?");
        string charRace = ReadLine();

        WriteLine($"What is your Characters Background? ");
        string charBackground = ReadLine();
        SharedCharacterClasses character = (SharedCharacterClasses)Activator.CreateInstance(clazz, charName, charRace, charBackground);
        return character;
    }

    static void Main(string[] args)
    {

        int userInput; //number input from user
        do
        {
            Clear();
            WriteLine("Welcome to the DND character information screen.");
            WriteLine("Please select a class to view information about a character.\n");
            WriteLine("     1. Barbarian");
            WriteLine("     2. Bard");
            WriteLine("     3. Cleric");
            WriteLine("     4. Druid");
            WriteLine("     5. Monk");
            WriteLine("     6. Ranger");
            WriteLine("     7. Warlock");
            WriteLine("     8. Wizard");
            WriteLine("     9. Exit\n");
            Write("> Please make a selection: ");
            userInput = int.Parse(ReadLine());

            if (userInput == 1)


            {
                Barbarian barbarian = (Barbarian)QuestionsForClass(typeof(Barbarian));

                Clear();
                WriteLine($"Skills specific to the barbarian. \n");
                barbarian.DisplaySpecificSkills();
                WriteLine($"\nplease pick one skill for this character: ");
                int barbPick = int.Parse(ReadLine());
                barbarian.SetBarbarianSkill(barbPick); //! barbarian specific skill
                barbarian.DisplayCharacter(); //! random skill from base
                ReadKey();
            }
            else if (userInput == 2) // below is for testing the call out to the other class methods
            {
                Bard bard = (Bard)QuestionsForClass(typeof(Bard));

                Clear();
                WriteLine($"Skills specific to the bard. \n");
                bard.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int bardPick = int.Parse(ReadLine());
                bard.SetBardSkill(bardPick); //! bard specific skill
                bard.DisplayCharacter(); //! random skill from base
                ReadKey();
            }
            else if (userInput == 3) //cleric
            {
                Cleric cleric = (Cleric)QuestionsForClass(typeof(Cleric));

                Clear();
                WriteLine($"Skills specific to the cleric. \n");
                cleric.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int clericPick = int.Parse(ReadLine());
                cleric.SetClericSkill(clericPick); //! cleric specific skill
                cleric.DisplayCharacter(); //! random skill from base
                ReadKey();
            }
            else if (userInput == 4) // druid
            {
                Druid druid = (Druid)QuestionsForClass(typeof(Druid));

                Clear();
                WriteLine($"Skills specific to the druid. \n");
                druid.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int druidPick = int.Parse(ReadLine());
                druid.SetDruidSkill(druidPick); //! druid specific skill
                druid.DisplayCharacter(); //! random skill from base
                ReadKey();
            }
            else if (userInput == 5) //monk
            {
                Monk monk = (Monk)QuestionsForClass(typeof(Monk));

                Clear();
                WriteLine($"Skills specific to the monk. \n");
                monk.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int monkPick = int.Parse(ReadLine());
                monk.SetMonkSkill(monkPick); //! monk specific skill
                monk.DisplayCharacter(); //! random skill from base
                ReadKey();
            }
            else if (userInput == 6) //ranger
            {
                Ranger ranger = (Ranger)QuestionsForClass(typeof(Ranger));

                Clear();
                WriteLine($"Skills specific to the ranger. \n");
                ranger.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int rangerPick = int.Parse(ReadLine());
                ranger.SetRangerSkill(rangerPick); //! ranger specific skill
                ranger.DisplayCharacter(); //! random skill from base
                ReadKey();
            }
            else if (userInput == 7) //warlock
            {

                Thread.Sleep(2000);
            }
            else if (userInput == 8) // wizard
            {

                Thread.Sleep(2000);
            }
        }
        while (userInput != 9);
    }
}