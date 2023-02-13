using System;

class WritingAssignment
{
    private string _title { get; set; }

    public WritingAssignment GetWritingInformation(string title)
    {
        return new WritingAssignment {_title = title};
    }
}


