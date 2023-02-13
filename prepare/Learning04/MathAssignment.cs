using System;

class MathAssignment
{
    private string _textBookSection {get; set; }
    private string _problems {get; set; }

    public MathAssignment GetHomeworkList(string textBookSelection, string problems)
    {
        return new MathAssignment {_textBookSection = textBookSelection, _problems = problems};
    }
}



