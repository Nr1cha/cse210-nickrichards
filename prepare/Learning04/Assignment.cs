public class Assignment
{
    // PRIVATE STUFF
    private string _studentName;
    private string _topic;

// CONSTRUCTOR
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // GETTERS
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }

    // METHOD
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

}

