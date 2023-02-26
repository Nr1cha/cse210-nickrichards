public class BreathingActivity : Activity
{
    // string _userInputBreath;
    private int _bIn;
    private int _bOut;

    public BreathingActivity() //CONSTRUCTOR
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing")
    {

    }

    public void Breath()
    {
        Console.Clear();
        base.WelcomeMessage();
        Console.Clear();
        Console.WriteLine($"Your session will last for {base.getDuration()} seconds.\n");
        Console.WriteLine("Get ready...");
        base.Animation(5);


        // read user input for breath in and breath out
        Console.Write("How many seconds would you like for your inhale? \n");
        _bIn = int.Parse(Console.ReadLine());
        Console.Write("How many seconds would you like for your exhale? \n");
        _bOut = int.Parse(Console.ReadLine());

        Console.WriteLine($"Start breathing exercise with {_bIn} seconds inhale and {_bOut} seconds exhale...\n");

        double loopTime = Math.Floor(Convert.ToDouble(base.getDuration() / (_bIn + _bOut)));
        for (double i = 1; i <= loopTime; i++)
        {

            Console.WriteLine($"Cycle {i}: Start breathin in...\n");
            Thread.Sleep(TimeSpan.FromSeconds(_bIn));

            Console.WriteLine("Start breathing out...\n");
            Thread.Sleep(TimeSpan.FromSeconds(_bOut));

        }

        base.endingMessage();
    }
}