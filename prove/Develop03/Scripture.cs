using System;

class Scripture
{
    private List<Word> _scriptureList = new List<Word>(); //OG word list
    private List<Word> _modifiedScriptureList = new List<Word>();
    private Reference _reference;


    public Scripture(Reference reference, string scriptureString) // CONSTRUCTOR
    {
        _reference = reference;

        string[] wordArray = scriptureString.Split(' ');
        List<Word> wordList = new List<Word>(); // INVOKING MY WORD CLASS
        List<Word> remainingWordsList = new List<Word>(); // remaining words list

        foreach (string currentWord in wordArray)
        {
            Word wordInstance = new Word(currentWord);
            wordList.Add(wordInstance); // adding to both lists
            remainingWordsList.Add(wordInstance); // adding to both lists
        };
        _modifiedScriptureList = remainingWordsList;
        _scriptureList = wordList;
    }


    // MAKE GETTERS AND SETTERS
    public List<Word> ModifiedScriptureList
    {
        get
        {
            return _modifiedScriptureList;
        }
        set
        {
            _modifiedScriptureList = value;
        }
    }

    public List<Word> ScriptureList
    {
        get
        {
            return _scriptureList;
        }
        set
        {
            _scriptureList = value;
        }
    }

    public void RemoveRandomWords(int maxNumberOfWordsToRemove)
    {
        Random random = new Random();
        int numberOfWordsToRemove = random.Next(1, maxNumberOfWordsToRemove);
        for (int i = 0; i < numberOfWordsToRemove; i++)
        {
            if (_modifiedScriptureList.Count > 0)
            {
                int randomNumber = random.Next(0, _modifiedScriptureList.Count);
                Word currentWord = _modifiedScriptureList[randomNumber];
                currentWord.IsHidden = true;
                _modifiedScriptureList.Remove(currentWord);
            }
        }
    }

    // DISPLAYING STUFF FROM THE LIST
    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.DisplayReference()}\n");
        foreach (Word currentWord in _scriptureList)
        {
            Console.Write($"{currentWord.Display()} "); //this shows the scripture
        }
    }

}