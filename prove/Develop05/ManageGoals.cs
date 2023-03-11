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
    public List<Goal> LoadGoals(string filename)
    {
        using (StreamReader textFile = new StreamReader(filename))
        {
            string line;
            List<Goal> _fileEntries = new List<Goal>();
            Goal newGoal;
            while ((line = textFile.ReadLine()) != null)
            {
                Console.WriteLine(line);
                if (line.StartsWith("Name:"))
                {
                    // newGoal = new SimpleGoal();
                }

            }
            _goalList = _fileEntries;
            return _fileEntries;
        }
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
            goalResult += ($"Goal Type: {goalItem.GetType()} \n");
            goalResult += goalItem.DisplayGoal() + "\n\n";
        }
        return goalResult;
    }
}