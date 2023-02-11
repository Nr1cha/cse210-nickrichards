using System;

class Reference
{
    private string _referenceScripture;
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _verse2;

    // CONSTRUCTOR
    public Reference(string book, int chapter, int verse) // single verse
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int verse2) // more than one verse
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verse2 = verse2;
    }

    public string DisplayReference()
    {
        if (_verse2 != null)
        {
            return ($"{_book} {_chapter}: {_verse} - {_verse2}");
        }
        else
        {
            return ($"{_book} {_chapter}: {_verse}");
        }
    }



    // getters and setters
    public string GetReference()
    {
        return _referenceScripture;
    }

    public void SetReference(string reference)
    {
        _referenceScripture = reference;
    }
}