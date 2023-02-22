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
    // TODO work on the first list type 
}