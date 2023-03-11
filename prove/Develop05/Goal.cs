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

    public virtual int RecordEvent()
    {
        return 0;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }


    public int GetPoints()
    {
        return _goalPoints;
    }
    public void SetPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }


    public virtual bool GetCompletedStatus()
    {
        return false;
    }

    public virtual void SetCompletedStatus(bool complete)
    {

    }

    public virtual string DisplayProgress()
    {
        return "";
    }

}