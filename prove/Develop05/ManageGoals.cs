public class ManageGoals
{
    List<Goal> _goalList = new List<Goal>();

    private int _points;
    private string _filePath;

    public ManageGoals()
    {
    }

    public void SaveAllGoals(string filePath)
    {
        _filePath = filePath;
        using(StreamWriter outputFile = new StreamWriter(_filePath))
        {
            foreach (Goal goalItem in _goalList)
            {
                // outputFile.WriteLine(goalItem.DisplayGoal());
            }
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

    public string DisplayGoals() //show the goals to the screen
    {
        List<string> goalEntry = new List<string>();
        foreach (Goal goalItem in _goalList)
        {
            // goalEntry.Add(goalItem.DisplayGoal());
        }
        string line = string.Join('\n', goalEntry);
        return line;
    }
}