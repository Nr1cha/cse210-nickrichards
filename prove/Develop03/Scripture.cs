using System;

class Scripture
{
    private List<Word> stringThing = new List<Word>();



    public Scripture(string stringThing) // CONSTRUCTOR
    {
        string[] wordArray = stringThing.Split(' ');
        List<Word> wordList = new List<Word>();

        foreach(string currentWord in wordArray)
        {
            wordList.Add(new Word(currentWord));
        };
        this.stringThing = wordList;

        //todo 1 
        // looping through each word
        foreach(string c in wordArray)
        {
            Console.WriteLine(c);
        }

    }

    // MAKE GETTERS AND SETTERS
    public List<Word> StringThing
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
        foreach (Word currentWord in stringThing)
        {
            Console.Write($"{currentWord.Display()} ");
        }
    }

}