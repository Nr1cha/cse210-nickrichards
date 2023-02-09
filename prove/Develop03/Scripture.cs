using System;

class Scripture
{
    private List<string> stringThing = new List<string>();



    public Scripture(string stringThing) // CONSTRUCTOR
    {
        string[] wordArray = stringThing.Split(' ');
        List<string> wordList = wordArray.ToList(); //turning it into a list of strings
        this.stringThing = wordList;
    }

    // MAKE GETTERS AND SETTERS
    public List<string> StringThing
    {
        get
        {
            return stringThing;
        }
        set
        {
            stringThing = value;
        }
    }
// DISPLAYING STUFF FROM THE LIST
    public void DisplayScripture()
    {
        foreach (string _word in stringThing)
        {
            Console.Write($"{_word} ");
        }
    }

}