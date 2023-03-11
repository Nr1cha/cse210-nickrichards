public class EternalGoal : Goal
{
    private int _numOfTimesCompleted = 0;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public EternalGoal(string name, string description, int points, int numOfTimesCompleted)
        : base(name, description, points)
    {
        _numOfTimesCompleted = numOfTimesCompleted;
    }

    public override int CalculatePoints()
    {
        return 6;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("test4");
    }

    public override string DisplayGoal()
    {
        string normalGoals = base.DisplayGoal();
        string allOfIt = ($@"{normalGoals}
number of times completed: {_numOfTimesCompleted}");
        return allOfIt;
    }

}