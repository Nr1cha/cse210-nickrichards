public class CheckListGoal : Goal
{
    private bool _isComplete = false;
    private int _numOfTimesRequired;
    private int _numOfTimesCompleted = 0;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int numOfTimesRequired, int bonusScore)
        : base(name, description, points)
    {
        _bonus = bonusScore;
        _numOfTimesRequired = numOfTimesRequired;
    }

    public CheckListGoal(string name, string description, int points, int numOfTimesRequired, int bonusScore, int numOfTimesCompleted, bool isComplete)
        : base(name, description, points)
    {
        _bonus = bonusScore;
        _numOfTimesRequired = numOfTimesRequired;
        _numOfTimesCompleted = numOfTimesCompleted;
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("test3");
    }
    public bool IsComplete()
    {
        return _isComplete;
    }

    public override string DisplayGoal()
    {
        string normalGoals = base.DisplayGoal();
        string allOfIt = ($@"{normalGoals}
Goal Bonus: {_bonus}
Times Required to get bonus: {_numOfTimesRequired}
Number of times completed: {_numOfTimesCompleted}
Completed: {_isComplete}");
        return allOfIt;
    }

    public override int CalculatePoints()
    {
        return 5;
    }

}