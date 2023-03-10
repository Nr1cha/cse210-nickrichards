public abstract class Goal
{
    private string _name;
    private string _description;
    private int _goalPoints;


    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _goalPoints = points;
    }

    public virtual void SaveGoal()
    {
        
    }

    public virtual int CalculatePoints()
    {
        return _goalPoints;
    }

    public void DisplayGoal()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Goal Points: {_goalPoints}");
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine("test");
    }

}