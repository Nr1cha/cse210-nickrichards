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
    public List<string> GetStrings() //GET
    {
        return stringThing;
    }

    public void SetScripture(List<string> pString) //SET
    {
        stringThing = pString;
    }

}