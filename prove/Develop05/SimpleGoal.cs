public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    private int _progress = 0;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {

    }
    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        // something will go here to record events;
        _isComplete = true;
        return CalculatePoints();
    }

    public override int CalculatePoints()
    {
        if (_isComplete == true)
        {
            return base.GetPoints();
        }
        else
        {
            return 0;
        }
    }
    // public void MarkAsComplete()
    // {
    //     _isComplete = true;
    // }

    public int GetProgress()
    {
        return _progress;
    }

    public void SetProgress(int progress)
    {
        _progress = progress;
    }

    public override bool GetCompletedStatus()
    {
        return _isComplete;
    }

    public override void SetCompletedStatus(bool complete)
    {
        _isComplete = complete;
    }

    public override string DisplayGoal()
    {
        string normalGoals = base.DisplayGoal();
        string allOfIt = ($@"{normalGoals}
Completed: {_isComplete}");
        return allOfIt;
    }

}