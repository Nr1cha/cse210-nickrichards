using System;

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
        }
        while (userInput != 9);
    }
}