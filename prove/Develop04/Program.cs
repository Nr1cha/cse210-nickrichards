using System;

class Program
{
    static void Main(string[] args)
    {
        // string _userSelection;


        // delay portion
        Activity testAct = new Activity();
        Console.WriteLine("i'll be back in a few seconds");
        testAct.Pausing(2000);
        Console.WriteLine($"I'm back");


        // animation portion
        Activity animation = new Activity();
        Console.Write(animation.Animation(75)); //how fast the animation will run
        Console.Clear();

        // main splash screen 
        // Console.Clear();
        // Console.WriteLine("Menu Options:");
        // Console.WriteLine("1. Start breathing activity");
        // Console.WriteLine("2. Start reflecting activity");
        // Console.WriteLine("3. Start listing activity");
        // Console.WriteLine("4. Quit");
        // Console.WriteLine("Please select a choice from the following menu: \n");
        // _userSelection = Console.ReadLine();


        // // SELECTION PORTION
        // if (_userSelection == "1")
        // {
        //     BreathingActivity _breathingActivity = new BreathingActivity();
        //     Console.WriteLine("option 1");

        // }
        // else if (_userSelection == "2")
        // {
        //     ReflectingActivity _reflectingActivity = new ReflectingActivity();
        //     Console.WriteLine("option 2 ");

        // }
        // else if (_userSelection == "3")
        // {
        //     ListingActivity _listingActivity = new ListingActivity();
        //     Console.WriteLine("option 3");

        // }
        // else if (_userSelection == "4")
        // {
        //     Console.WriteLine("Thanks for Participating");
        //     System.Environment.Exit(0);


        // }


        // COUNT DOWN FROM 5 

        for (int i = 5; i >= 1; i--)
        {
            Console.Write(i);

            for (int j = 0; j< 3; j++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(250); // Wait for 1/4 of a second
            }
            System.Threading.Thread.Sleep(750); // wait for 3/4 of a second
        }
        Console.Clear();
        Console.WriteLine("GO!");
        Console.ReadLine(); // Wait for user to press a key before exiting


        // // breating in and out 
        // Console.Clear();
        // const int interval = 4000; // interval in milliseconds between "breath in" and "breath out" texts
        // const int duration = 25000; // duration in milliseconds of the breathing exercise

        // int elapsed = 0;
        // while (elapsed < duration)
        // {
        //     Console.WriteLine("Breath in...\n");
        //     Thread.Sleep(interval);
        //     Console.WriteLine("Breath out...\n");
        //     Thread.Sleep(interval);
        //     elapsed += 2 * interval;
        // }

        // Console.WriteLine("Exercise complete.");
        // Console.WriteLine("Well Done!");




    }
}