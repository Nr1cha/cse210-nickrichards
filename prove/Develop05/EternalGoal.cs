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
        return _numOfTimesCompleted * base.GetPoints();
    }

    public override int RecordEvent()
    {
        _numOfTimesCompleted += 1;
        return CalculatePoints();
    }

    public override string DisplayGoal()
    {
        string normalGoals = base.DisplayGoal();
        string allOfIt = ($@"{normalGoals}
number of times completed: {_numOfTimesCompleted}");
        return allOfIt;
    }

    public override bool GetCompletedStatus()
    {
        return false;
    }

    public override void SetCompletedStatus(bool complete)
    {

    }

}