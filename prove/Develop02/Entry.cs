using System;

class Entry
{
    
    // list of attributes/variables
    public string _userInput = "";
    public string _date = "";
    // public Prompt _prompt;

    public Entry()
    {
        
    }
    public string Display()
    {
        // Console.WriteLine($"{_date}");
        // TODO add prompt to return 
        // Console.WriteLine($"{_userInput}");
        return $"{_date} {_userInput}";
    }

}