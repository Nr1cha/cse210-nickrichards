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

    public Goal()
    {

    }

    public virtual void SaveGoal()
    {
        
    }

    public virtual int CalculatePoints()
    {
        return _goalPoints;
    }

    public virtual string DisplayGoal()
    {
        string goalName = ($"Name: {_name}");
        string goalDescription = ($"Description: {_description}");
        string goalPoints = ($"Goal Points: {_goalPoints}");
        string result = ($"{goalName} \n{goalDescription} \n{goalPoints}");
        return result;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine("test");
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

}