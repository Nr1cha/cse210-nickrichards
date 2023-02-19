public class WritingAssignment : Assignment
{
    private string _title;

// CONSTRUCTOR CALLING TO BASE CLASS
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

// METHOD
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }

}
