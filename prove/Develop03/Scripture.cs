using System;

class Scripture
{
    private List<Word> _stringThing = new List<Word>(); //OG word list
    private List<Word> _modifiedStringThing = new List<Word>();


    public Scripture(string stringThing) // CONSTRUCTOR
    {
        string[] wordArray = stringThing.Split(' ');
        List<Word> wordList = new List<Word>(); // INVOKING MY WORD CLASS
        List<Word> remainingWordsList = new List<Word>(); // remaining words list


        foreach (string currentWord in wordArray)
        {
            // adding to both lists
            Word wordInstance = new Word(currentWord);
            wordList.Add(wordInstance);
            remainingWordsList.Add(wordInstance);

        };
        _modifiedStringThing = remainingWordsList;
        _stringThing = wordList;
    }

    // public Scripture(string bigScripture)
    // {

    // } 

    // MAKE GETTERS AND SETTERS
    public List<Word> ModifiedStringThing
    {
        get
        {
            return _modifiedStringThing;
        }
        set
        {
            _modifiedStringThing = value;
        }
    }


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
        if (_modifiedStringThing.Count > 0)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, _modifiedStringThing.Count);
            Word currentWord = _modifiedStringThing[randomNumber];
            currentWord.IsHidden = true;


            //word that is looked at to be removed
            _modifiedStringThing.Remove(currentWord);
        }
    }


    // DISPLAYING STUFF FROM THE LIST
    public void DisplayScripture()
    {
        foreach (Word currentWord in _stringThing)
        {
            Console.Write($"{currentWord.Display()} "); //this shows the scripture
        }
    }

}