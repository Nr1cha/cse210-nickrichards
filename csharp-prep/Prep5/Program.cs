using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    static String PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }


    static int PromptUserNumber()
    {
        Console.Write("what is your favorite number?");
        int userFavNum = int.Parse(Console.ReadLine());
        return userFavNum;
    }


    static int SquareNumber(int num)
    {
        int newNum = num * num;
        return newNum;
    }

    static void DisplayResult(string userName, int userFavNum)
    {
        Console.Write($"{userName}, the square of your number is {userFavNum}");

    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string usersName = PromptUserName();
        int usersNum = PromptUserNumber();
        int squaredNum = SquareNumber(usersNum);
        DisplayResult(usersName, squaredNum); 

    }
}