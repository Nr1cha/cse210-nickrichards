using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"what is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine($"what is your lastname?");
        string lastName = Console.ReadLine();

        // DerivedClass derived = new DerivedClass(firstName);
        // derived.DisplayName();
    }
}