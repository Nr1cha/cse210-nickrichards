using System;

class Program
{
    static void Main(string[] args)
    {
        // random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher ");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower ");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        }
    }
}