public class ManageGoals
{
    private List<Goal> _goalList = new List<Goal>(); //todo here is my goal list

    private int _points;
    private string _filePath;

    public ManageGoals()
    {
    }

    public void SaveAllGoals(string filePath)
    {
        _filePath = filePath;
        using (StreamWriter outputFile = new StreamWriter(_filePath))
        {
            outputFile.WriteLine(DisplayGoals());
        }

    }
    public void LoadGoals()
    {

    }

    public void AddGoalsToList(Goal goal)
    {
        _goalList.Add(goal);
    }


    public int DisplayPoints(int points) //show the points to the screen
    {
        _points = points;
        return _points;
    }

    public string DisplayGoals() //show the goals to the screen //*done
    {
        string goalResult = "";
        foreach (Goal goalItem in _goalList)
        {
            goalResult += "\n\n" + goalItem.DisplayGoal();
        }
        return goalResult;
    }
}