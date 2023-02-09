using System;
using System.Collections.Generic;

public class Word
{
    // NEW INSTANCE OF SCRIPTURE CLASS
    // List<string> scriptureWords1 = new List<string>();
    // Scripture scriptureWords;
    string _word = "";
    Boolean _isHidden = false;
    public Word(string word)
    {
        this._word = word;
    }

    public Boolean IsHidden
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
                outPutWord += "_";
            }
        }
        else
        {
            outPutWord = _word;
        }

        return outPutWord;
    }
}
