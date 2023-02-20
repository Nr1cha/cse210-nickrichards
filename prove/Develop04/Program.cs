using System;

class Program
{
    static void Main(string[] args)
    {

        // delay portion
        Activity testAct = new Activity();
        Console.WriteLine("i'll be back in a few seconds");
        testAct.Pausing(5000);
        Console.WriteLine($"I'm back");


        // animation portion
        Activity animation = new Activity();
        Console.Write(animation.Animation(500));
        
    }
}