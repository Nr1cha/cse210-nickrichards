using System;

public class Job
{
    // this is a list of attributes/variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;


// constructor. this can be empty
    public Job()
    {

    }

// method to display and format the template
    public void Display()
    {
        Console.WriteLine($"{_company}");
        Console.WriteLine($"{_jobTitle}");
        Console.WriteLine($"{_startYear}");
        Console.WriteLine($"{_endYear}");
    }
}