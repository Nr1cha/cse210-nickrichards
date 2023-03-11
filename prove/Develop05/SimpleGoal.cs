public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    private int _progress = 0;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {

    }
    public SimpleGoal()
        : base()
    {

    }

    public override void RecordEvent()
    {
        // something will go here to record events;
        Console.WriteLine("test2");
    }

    public void MarkAsComplete()
    {
        _isComplete = true;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public int GetProgress()
    {
        return _progress;
    }

    public void SetProgress(int progress)
    {
        _progress = progress;
    }

}