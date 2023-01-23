using System;
// the prompt is the random questions to ask the user when they select to write a journal
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