class MathAssignment : Assignment
{
    // PRIVATE ATTRIBUTES
    private string _textBookSection;
    private string _problems;

// CALL TO BASE CLASS WITH CONSTRUCTOR
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textBookSection = textbookSection;
        _problems = problems;
    }

// METHOD
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }

}



