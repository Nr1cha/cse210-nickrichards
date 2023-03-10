public class CheckListGoal : Goal
{
    private bool isComplete;
    private int _numOfTimesRequired;
    private int _numOfTimesCompleted;
    private int _bonus;

    public override void RecordEvent()
    {
        Console.WriteLine("test3");
    }
    public bool IsComplete()
    {

    }

    public override int CalculatePoints()
    {
        return 5;
    }

}