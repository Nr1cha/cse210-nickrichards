using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Programmer";
        job1._startYear = 2002;
        job1._endYear = 2022;
        job1.Display();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "UX Designer";
        job2._startYear = 2005;
        job2._endYear = 2020;
        job2.Display();

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();
    }
}