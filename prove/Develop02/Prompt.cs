using System;

class Prompt
{

    public Prompt()
    {
        
    }
    // list of attributes/variables
    public string _userPrompt = "";

    public void Display()
    {
        Console.WriteLine($"{_userPrompt}");
    }
}