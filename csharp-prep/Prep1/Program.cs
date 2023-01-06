using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        // BREAK
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        // JAMES BOND OUTPUT
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}