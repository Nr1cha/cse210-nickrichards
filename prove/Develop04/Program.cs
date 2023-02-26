using System;

class Program
{
    static void Main(string[] args)
    {

        // main splash screen 

        string _userSelection;
        int _userMainInput = 0; //menu selection

        // SELECTION PORTION
        while (_userMainInput != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please select a choice from the menu: \n");
            _userSelection = Console.ReadLine();
            _userMainInput = int.Parse(_userSelection); //menu selection


            if (_userMainInput == 1) // BREATHING ACTIVITY
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Breath();
            }
            else if (_userMainInput == 2)
            {
                Console.WriteLine("here?");
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                Console.Write("here...");
                reflectingActivity.Reflect();
            }
            else if (_userMainInput == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.List();

            }
            else if (_userMainInput == 4)
            {
                Console.WriteLine("Thanks for Participating");
                System.Environment.Exit(0);

            }

        }
    }

}