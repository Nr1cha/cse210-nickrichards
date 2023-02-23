public class BreathingActivity : Activity
{
    // string _userInputBreath;
    string _bIn;
    string _bOut;

    public BreathingActivity(int duration) //CONSTRUCTOR
        : base(duration)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        Console.WriteLine($"Your session will last for {duration} seconds.\n");
        Console.WriteLine("Get ready...");

        // read user input for breath in and breath out
        Console.WriteLine("How many seconds would you like for your inhale?");
        _bIn = Console.ReadLine();
        Console.WriteLine("How many seconds would you like for your exhale?");
        _bOut = Console.ReadLine();
    }

    public void RunActivity(string _bIn, string _bOut)
    {
        base.textLoop();
        Console.WriteLine($"Start breathing exercise with {_bIn} seconds inhale and {_bOut} seconds exhale...");
        // implement breathing activity using _bIn and _bOut variables
        int numCycles = 5; //how ever many cycles i want
        for (int i = 1; i <= numCycles; i++)
        {
            Console.WriteLine($"Cycle {i}: Start breathin in...");
            Thread.Sleep(TimeSpan.FromSeconds(int.Parse(_bIn)));
            Console.WriteLine("Hold your breath...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Start breathing out...");
            Thread.Sleep(TimeSpan.FromSeconds(int.Parse(_bOut)));
            Console.WriteLine("End of exhale, hold for a few seconds...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        Console.WriteLine("Breathing exercise complete");

    }
    
}