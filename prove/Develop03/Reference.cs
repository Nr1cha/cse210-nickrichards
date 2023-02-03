using System;

class Reference
{
    private string _referenceScripture;

    // CONSTRUCTOR
    public Reference()
    {

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