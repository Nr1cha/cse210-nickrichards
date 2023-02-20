using System;

class Program
{
    static void Main(string[] args)
    {

        Activity testAct = new Activity();
        Console.WriteLine("i'll be back in a few seconds");
        testAct.Pausing(5000);
        Console.WriteLine($"I'm back");


        // animation portion
        // string[] spinner = { "/", "-", "\\", "|" };
        // int i = 0;
        // DateTime startTime = DateTime.Now;
        // TimeSpan Duration = new TimeSpan(0, 0, 5);
        // while (DateTime.Now - startTime < Duration)
        // {

        //     Console.Write("\r" + spinner[i]);
        //     testAct.Pausing(200);
        //     i = (i + 1) % spinner.Length;

        // }
        
        Activity animation = new Activity();
        Console.Write(animation.Animation(500));
    }
}