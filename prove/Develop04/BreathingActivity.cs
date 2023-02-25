public class BreathingActivity : Activity
{
    // string _userInputBreath;
    int _bIn;
    int _bOut;

    public BreathingActivity(int duration, string activityName, string activityDescription) //CONSTRUCTOR
        : base(duration, activityName, activityDescription)
    {

    }

    public void Breath()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        Console.WriteLine($"Your session will last for {base.getDuration()} seconds.\n");
        Console.WriteLine("Get ready...");

        // read user input for breath in and breath out
        Console.WriteLine("How many seconds would you like for your inhale?");
        _bIn = int.Parse(Console.ReadLine());
        Console.WriteLine("How many seconds would you like for your exhale?");
        _bOut = int.Parse(Console.ReadLine());


        // NEXT SECTION

        // base.textLoop();
        Console.WriteLine($"Start breathing exercise with {_bIn} seconds inhale and {_bOut} seconds exhale...");
        // implement breathing activity using _bIn and _bOut variables
        int numCycles = 5; //how ever many cycles i want
        for (int i = 1; i <= numCycles; i++)
        {
            Console.WriteLine($"Cycle {i}: Start breathin in...");
            Thread.Sleep(TimeSpan.FromSeconds(_bIn));
            Console.WriteLine("Hold your breath...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Start breathing out...");
            Thread.Sleep(TimeSpan.FromSeconds(_bOut));
            Console.WriteLine("End of exhale, hold for a few seconds...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        Console.WriteLine("Breathing exercise complete");
    }

}