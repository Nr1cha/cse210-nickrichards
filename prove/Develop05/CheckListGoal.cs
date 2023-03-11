public class CheckListGoal : Goal
{
    private bool _isComplete;
    private int _numOfTimesRequired;
    private int _numOfTimesCompleted;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int bonusNum, int bonusScore)
        : base(name, description, points)
    {
        _bonus = bonusScore;
        _numOfTimesRequired = bonusNum;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("test3");
    }
    public bool IsComplete()
    {
        return _isComplete;
    }

    public override int CalculatePoints()
    {
        return 5;
    }

}