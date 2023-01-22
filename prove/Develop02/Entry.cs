using System;

class Entry
{
    // list of attributes/variables
    public string _userInput = "";
    public string _date = "";

    public void Display()
    {
        Console.WriteLine($"{_userInput}");
        Console.WriteLine($"{_date}");
    }

}