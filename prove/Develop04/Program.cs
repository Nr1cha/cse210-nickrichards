using System;

class Program
{
    static void Main(string[] args)
    {
        // string _userSelection;


        // delay portion
        // Activity testAct = new Activity();
        // Console.WriteLine("i'll be back in a few seconds");
        // testAct.Pause(2000);
        // Console.WriteLine($"I'm back");


        // animation portion
        // Activity animation = new Activity();
        // animation.Animation(75);
        // Console.Clear();

        // // COUNT DOWN FROM 5 
        // Activity timer = new Activity();
        // string _userTimer;
        // Console.WriteLine("choose how many seconds would you like");
        // _userTimer = Console.ReadLine();
        // int timerTime = int.Parse(_userTimer);
        // Console.Write(timer.Timer(timerTime));

        // // TEXT LOOP 
        // Activity textLoop = new Activity();
        // Console.Write(textLoop.textLoop());

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
            Console.WriteLine("Please select a choice from the following menu: \n");
            _userSelection = Console.ReadLine();
            _userMainInput = int.Parse(_userSelection); //menu selection



            if (_userMainInput == 1) // BREATHING ACTIVITY
            {
                // Console.WriteLine("how long would you like your breathing activity to last in seconds? ");
                // int breathingSeconds = int.Parse(Console.ReadLine());
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
            // else if (_userMainInput == 3)
            // {
            //     ListingActivity _listingActivity = new ListingActivity();
            //     Console.WriteLine("option 3");

            // }
            // else if (_userMainInput == 4)
            // {
            //     Console.WriteLine("Thanks for Participating");
            //     System.Environment.Exit(0);

            // }

        }
    }

}