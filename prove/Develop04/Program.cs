using System;

class Program
{
    static void Main(string[] args)
    {
        // this portion calls and uses my Activity class
        Activity testAct = new Activity(); //making a var that invokes the use of class
        Console.WriteLine("i'll be back in a few seconds");
        testAct.Pausing(5000); //sleep for 5 seconds from Activity class
        Console.WriteLine($"I'm back");
    }
}