using System;


class Assignment // constructor
{
    private string _studentName;
    private string _topic;


    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }



// GETTERS AND SETTERS
public string GetStudentName()
{
    return _studentName;
}
public string GetTopic()
{
    return _topic;
}

// METHOD(S)

public string GetSummary()
{
    return  _studentName + "- " + _topic;
}

}

