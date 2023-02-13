using System;


class Assignment // constructor
{
private string _studentName {get; set;}
private string _topic {get; set;}

public Assignment GetSummary(string studentName, string topic)
{
    return new Assignment { _studentName = studentName, _topic = topic };
}

}
