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
        return $"{_date} \n{_prompt} \n{_userInput} \n";
    }

}