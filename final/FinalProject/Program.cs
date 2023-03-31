using System;
using System.Threading;
using static System.Console;

class Program
{
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
                Clear();
                // * work on the input for the name, race and background
                WriteLine($"What is your Characters name?");
                string charName = ReadLine();

                WriteLine($"What is your Characters race?");
                string charRace = ReadLine();

                WriteLine($"What is your Characters Background? ");
                string charBackground = ReadLine();

                Barbarian barbarian = new Barbarian(charName, charRace, charBackground);

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
                WriteLine($"What is your Characters name?");
                string charName = ReadLine();

                WriteLine($"What is your Characters race?");
                string charRace = ReadLine();

                WriteLine($"What is your Characters Background? ");
                string charBackground = ReadLine();
                Bard bard = new Bard(charName, charRace, charBackground);

                Clear();
                WriteLine($"Skills specific to the bard. \n");
                bard.DisplaySpecificSkills();
                WriteLine($"\nplease pick one skill for this character: ");
                int bardPick = int.Parse(ReadLine());
                bard.SetBarbarianSkill(bardPick); //! bard specific skill
                bard.DisplayCharacter(); //! random skill from base
                ReadKey();
            }
            else if (userInput == 3)
            {
                // Cleric welcomeCleric = new Cleric();
                // string welcome = welcomeCleric.DisplayCleric();
                // Console.WriteLine(welcome);
                Thread.Sleep(2000);
            }
            else if (userInput == 4)
            {
                // Druid welcomeDruid = new Druid();
                // string welcome = welcomeDruid.DisplayDruid();
                // Console.WriteLine(welcome);
                Thread.Sleep(2000);
            }
            else if (userInput == 5)
            {
                // Monk welcomeMonk = new Monk();
                // string welcome = welcomeMonk.DisplayMonk();
                // Console.WriteLine(welcome);
                Thread.Sleep(2000);
            }
            else if (userInput == 6)
            {
                // Ranger welcomeRanger = new Ranger();
                // string welcome = welcomeRanger.DisplayRanger();
                // Console.WriteLine(welcome);
                Thread.Sleep(2000);
            }
            else if (userInput == 7)
            {
                // Warlock welcomeWarlock = new Warlock();
                // string welcome = welcomeWarlock.DisplayWarlock();
                // Console.WriteLine(welcome);
                Thread.Sleep(2000);
            }
            else if (userInput == 8)
            {
                // Wizard welcomeWizard = new Wizard();
                // string welcome = welcomeWizard.DisplayWizard();
                // Console.WriteLine(welcome);
                Thread.Sleep(2000);
            }
        }
        while (userInput != 9);
    }
}