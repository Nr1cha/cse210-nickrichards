using System;

class Reference
{
    private string _referenceScripture;

    // CONSTRUCTOR
    public Reference()
    {

    }

    public void DisplayReference()
    {
        Console.WriteLine("test");
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