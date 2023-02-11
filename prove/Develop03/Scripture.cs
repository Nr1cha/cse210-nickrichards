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
            Word wordInstance = new Word(currentWord);
            wordList.Add(wordInstance); // adding to both lists
            remainingWordsList.Add(wordInstance); // adding to both lists
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

    public void RemoveRandomWords(int maxNumberOfWordsToRemove)
    {
        Random random = new Random();
        int numberOfWordsToRemove = random.Next(1, maxNumberOfWordsToRemove);
        for (int i = 0; i < numberOfWordsToRemove; i++)
        {
            if (_modifiedStringThing.Count > 0)
            {
                int randomNumber = random.Next(0, _modifiedStringThing.Count);
                Word currentWord = _modifiedStringThing[randomNumber];
                currentWord.IsHidden = true;
                _modifiedStringThing.Remove(currentWord);
            }
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