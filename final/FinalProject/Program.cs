using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int userInput; //number input from user
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the DND character information screen.");
            Console.WriteLine("Please select a class to view information about a character.\n");
            Console.WriteLine("     1. Barbarian");
            Console.WriteLine("     2. Bard");
            Console.WriteLine("     3. Cleric");
            Console.WriteLine("     4. Druid");
            Console.WriteLine("     5. Monk");
            Console.WriteLine("     6. Ranger");
            Console.WriteLine("     7. Warlock");
            Console.WriteLine("     8. Wizard");
            Console.WriteLine("     9. Exit\n");
            Console.Write("> Please make a selection: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                var player = new Barbarian(
                    characterName: "Barbarian Name",
                    race: "High elf",
                    background: "Nomad in the woods, traveling and taking contracts to make a living.",
                    inventory: new List<string> { "item1", "item2", "item3" },
                    bSkill1: ("fighter"),
                    bSkill2: ("Tank"),
                    bSkill3: ("Perception")
                );
                Console.WriteLine($"{player.DisplayBarbarian}");
                // Barbarian welcome = new Barbarian(); //calling the class
                // string message = welcome.DisplayBarbarian(); // adding the class method to a string
                // Console.WriteLine(message); //displaying the string
                Console.ReadKey();
            }
            else if (userInput == 2) // below is for testing the call out to the other class methods
            {
                // Bard welcomeBard = new Bard();
                // string welcome = welcomeBard.DisplayBard();
                // Console.WriteLine(welcome);
                Thread.Sleep(2000);
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