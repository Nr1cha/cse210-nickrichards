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

    // TODO work on the count-down and count-up timmer next
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


    // TODO work on the first list type 
}