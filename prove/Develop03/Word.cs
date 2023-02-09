using System;
using System.Collections.Generic;

public class Word
{
    // NEW INSTANCE OF SCRIPTURE CLASS
    List<string> scriptureWords1 = new List<string>();
    Scripture scriptureWords;
    string _word = "";
    Boolean _isHidden = false;
    public Word(string word)
    {

        this._word = word;
    }



    public void ReplaceWords()
    {
        // for (int i = 0; i < scriptureWords.wordList.Count; i++)
        // {
        //     string wordToChange = scriptureWords.wordList[i];

        //     if (wordToChange == scriptureWords.wordList[i])
        //     {
        //         scriptureWords.wordList[i] = "_";
        //     }
        // }

        // foreach (string replacedWord in scriptureWords.wordList)
        // {
        //     Console.WriteLine(replacedWord);
        // }
    }

    public Boolean isHidden
    {
        get
        {
            return _isHidden;
        }
        set
        {
            _isHidden = value;
        }
    }

    public string Display()
    {
        string outPutWord = "";

        if (_isHidden)
        {
            foreach (char letter in _word)
            {
                outPutWord = outPutWord+"_";
            }
        }
    }
}
