using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        string letter;
        // int f;

        // Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is Your grade percentage?");
        string userGradeInput = Console.ReadLine();
        int userScore = int.Parse(userGradeInput);

        if (userScore >= a)
        {
            letter = "A";
        }
        else if (userScore >= b)
        {
            letter = "B";
        }
        else if (userScore >= c)
        {
            letter = "C";
        }
        else if (userScore >= d)
        {
            letter = "D";
        }
        else
        {
            letter = "F Please take the course again";
        }
            Console.WriteLine($"Your grade is = {letter}.");
    }
}