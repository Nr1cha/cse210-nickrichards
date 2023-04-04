using System;
using System.Threading;
using static System.Console;

class Program
{
    static SharedCharacterClasses QuestionsForClass(Type clazz)
    {
        Clear();
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

        int userInput;
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
                barbarian.SetBarbarianSkill(barbPick);
                barbarian.DisplayCharacter();
                ReadKey();
            }
            else if (userInput == 2)
            {
                Bard bard = (Bard)QuestionsForClass(typeof(Bard));

                Clear();
                WriteLine($"Skills specific to the bard. \n");
                bard.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int bardPick = int.Parse(ReadLine());
                bard.SetBardSkill(bardPick);
                bard.DisplayCharacter();
                ReadKey();
            }
            else if (userInput == 3)
            {
                Cleric cleric = (Cleric)QuestionsForClass(typeof(Cleric));

                Clear();
                WriteLine($"Skills specific to the cleric. \n");
                cleric.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int clericPick = int.Parse(ReadLine());
                cleric.SetClericSkill(clericPick);
                cleric.DisplayCharacter();
                ReadKey();
            }
            else if (userInput == 4)
            {
                Druid druid = (Druid)QuestionsForClass(typeof(Druid));

                Clear();
                WriteLine($"Skills specific to the druid. \n");
                druid.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int druidPick = int.Parse(ReadLine());
                druid.SetDruidSkill(druidPick);
                druid.DisplayCharacter();
                ReadKey();
            }
            else if (userInput == 5)
            {
                Monk monk = (Monk)QuestionsForClass(typeof(Monk));

                Clear();
                WriteLine($"Skills specific to the monk. \n");
                monk.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int monkPick = int.Parse(ReadLine());
                monk.SetMonkSkill(monkPick);
                monk.DisplayCharacter();
                ReadKey();
            }
            else if (userInput == 6)
            {
                Ranger ranger = (Ranger)QuestionsForClass(typeof(Ranger));

                Clear();
                WriteLine($"Skills specific to the ranger. \n");
                ranger.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int rangerPick = int.Parse(ReadLine());
                ranger.SetRangerSkill(rangerPick);
                ranger.DisplayCharacter();
                ReadKey();
            }
            else if (userInput == 7)
            {
                Warlock warlock = (Warlock)QuestionsForClass(typeof(Warlock));

                Clear();
                WriteLine($"Skills specific to the warlock. \n");
                warlock.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int warlockPick = int.Parse(ReadLine());
                warlock.SetWarlockSkill(warlockPick);
                warlock.DisplayCharacter();
                ReadKey();
            }
            else if (userInput == 8)
            {
                Wizard wizard = (Wizard)QuestionsForClass(typeof(Wizard));

                Clear();
                WriteLine($"Skills specific to the wizard. \n");
                wizard.DisplaySpecificSkills();
                WriteLine($"\nplease select one skill for this character: ");
                int wizardPick = int.Parse(ReadLine());
                wizard.SetWizardSkill(wizardPick);
                wizard.DisplayCharacter();
                ReadKey();
            }
        }
        while (userInput != 9);
    }
}