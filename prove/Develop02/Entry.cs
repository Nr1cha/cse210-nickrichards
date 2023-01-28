using System;

class Entry
{

    // list of attributes/variables
    public string _userInput = "";
    public string _date = "";
    public string _prompt = "";

    public Entry()
    {

    }
    public string Display()
    {
        return $"Date: {_date} \nPrompt: {_prompt} \nEntry: {_userInput} \n";
    }

}