using System;

class Program
{
    static void Main(string[] args)
    {
        // calling the blueprint from the Fraction class
        Fraction f1 = new Fraction(); //new means i'm using it
        Console.WriteLine(f1.GetFractionString()); //using the methods from th fraction class
        Console.WriteLine(f1.GetDecimalValue()); //using the methods from th fraction class

        Fraction f2 = new Fraction(5); //passing 5 into the blueprint
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4); //passing 3 and 4 to use in the blueprint
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        
    }
}