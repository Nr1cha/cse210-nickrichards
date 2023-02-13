using System;

class MathAssignment
{
    private string _textBookSection;
    private string _problems;



    // GETTERS AND SETTERS

    public string GetTextBookSelection()
    {
        return _textBookSection;
    }
    public void SetTextBookSelection(string textBookSelection)
    {
        _textBookSection = textBookSelection;
    }

    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }


}



