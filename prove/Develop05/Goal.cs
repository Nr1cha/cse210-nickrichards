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

    public abstract void SaveGoal();

    public int calculatePoints()
    {
        return _goalPoints;
    }

    public void DisplayGoal()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Name: {_description}");
        Console.WriteLine($"Name: {_goalPoints}");
    }

    public void RecordEvent()
    {

    }

}