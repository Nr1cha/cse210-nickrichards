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
        TimeSpan Duration = new TimeSpan(0, 0, milliseconds);
        while (DateTime.Now - startTime < Duration)
        {

            Console.Write("\r" + spinner[i]);
            Thread.Sleep(milliseconds);
            i = (i + 1) % spinner.Length;

        }
        return "";

    }
}