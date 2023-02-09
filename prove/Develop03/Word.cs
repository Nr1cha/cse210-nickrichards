using System;
using System.Collections.Generic;

public class Word
{
    // NEW INSTANCE OF SCRIPTURE CLASS
    List<string> scriptureWords1 = new List<string>();
    Scripture scriptureWords;

    public Word()
    {
        scriptureWords = new Scripture(scriptureWords1);

        // constructor
    }

    // iterate through a list
    // take list from the scripture class

    public void ReplaceWords()
    {
        for (int i = 0; i < scriptureWords.wordList.Count; i++)
        {
            string wordToChange = scriptureWords.wordList[i];

            if (wordToChange == scriptureWords.wordList[i])
            {
                scriptureWords.wordList[i] = "_";
            }
        }

        foreach (string replacedWord in scriptureWords.wordList)
        {
            Console.WriteLine(replacedWord);
        }
    }
}
