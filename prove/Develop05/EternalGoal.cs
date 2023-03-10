public class EternalGoal : Goal
{
    private int _numOfTimesCompleted;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int CalculatePoints()
    {
        return 6;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("test4");
    }

}