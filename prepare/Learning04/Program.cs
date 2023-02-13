using System;

class Program
{

    static void Main(string[] args)
    {
        Assignment studentInfo = new Assignment("John Doe", "Computer Science");
        Console.WriteLine(studentInfo.GetSummary());
    }
}