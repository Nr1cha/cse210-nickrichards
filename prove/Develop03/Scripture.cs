using System;

class Scripture
{
    private List<Word> _stringThing = new List<Word>();



    public Scripture(string stringThing) // CONSTRUCTOR
    {
        string[] wordArray = stringThing.Split(' ');
        List<Word> wordList = new List<Word>(); // INVOKING MY WORD CLASS

        foreach (string currentWord in wordArray)
        {
            wordList.Add(new Word(currentWord));
        };
        _stringThing = wordList;
    }

    // public Scripture(string bigScripture)
    // {

    // } 

    // MAKE GETTERS AND SETTERS
    public List<Word> StringThing
    {
        get
        {
            return _stringThing;
        }
        set
        {
            _stringThing = value;
        }
    }

    // function for remove random word
    public void RemoveRandomWord()
    {
        //todo 1 
        // looping through each word
        Random random = new Random();
        int randomNumber = random.Next(1, _stringThing.Count);
        _stringThing[randomNumber].IsHidden = true;
        // foreach (Word c in _stringThing)
        // {
        //     c.IsHidden = true;
        //     Console.WriteLine(c.Display(randomNumber));
        // }
    }


    // DISPLAYING STUFF FROM THE LIST
    public void DisplayScripture()
    {
        foreach (Word currentWord in _stringThing)
        {
            Console.Write($"{currentWord.Display()} ");
        }
    }

}