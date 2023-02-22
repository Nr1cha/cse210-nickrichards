using System.Threading;
public class Activity
{
    public Activity()
    {
        // Console.WriteLine("this is a test");

    }


    // pause method
    public void Pausing(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    // animation method
    public string Animation(int milliseconds)
    {

        string[] spinner = { "/", "-", "\\", "|" };
        int i = 0;
        DateTime startTime = DateTime.Now;
        // timespan = hrs, min, sec
        TimeSpan Duration = new TimeSpan(0, 0, 5); //how long the animation will last in seconds
        while (DateTime.Now - startTime < Duration)
        {

            Console.Write("\r" + spinner[i]);
            Thread.Sleep(milliseconds);
            i = (i + 1) % spinner.Length;

        }
        return "";

    }

    // * work on the count-down and count-up timmer next
    //COUNT-DOWN TIMMER
    public string Timer(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);

            for (int j = 0; j < 3; j++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(200); // Wait for 1/4 of a second

            }
            System.Threading.Thread.Sleep(750); // wait for 3/4 of a second
        }
        Console.Clear();
        Console.WriteLine("GO!");
        Console.ReadLine(); // Wait for user to press a key before exiting
        return "";
    }



// *DONE text loop is done
    public string textLoop()
    {
        Console.Clear();
        const int interval = 4000; // interval in milliseconds between "breath in" and "breath out" texts
        const int duration = 25000; // duration in milliseconds of the breathing exercise

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("Breath in...\n");
            Thread.Sleep(interval);
            Console.WriteLine("Breath out...\n");
            Thread.Sleep(interval);
            elapsed += 2 * interval;
        }

        Console.WriteLine("Exercise complete.");
        Console.WriteLine("Well Done!");
        return "";
    }

    // TODO work on the first list type 
}