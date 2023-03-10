public class EternalGoal : Goal
{
    private int _numOfTimesCompleted;

    public override int CalculatePoints()
    {
        return 6;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("test4");
    }

}