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
    public void LoadGoals(string filename)
    {
        using (StreamReader textFile = new StreamReader(filename))
        {
            string line;
            List<Goal> _fileEntries = new List<Goal>();
            // Goal newGoal;
            List<string> goalLines = new List<string>();
            while ((line = textFile.ReadLine()) != null)
            {
                Console.WriteLine(line);
                goalLines.Add(line);
                if (line == "")
                {
                    string goalType = "";
                    string goalName = "";
                    string goalDescription = "";
                    int goalPoints = 0;
                    int goalBonus = 0;
                    int numOfTimesCompleted = 0;
                    bool completed = false;
                    int numOfTimesRequired = 0;
                    foreach (string goalLine in goalLines)
                    {

                        if (goalLine.StartsWith("Goal Type:"))
                        {
                            goalType = goalLine.Replace("Goal Type: ", "").Trim();
                        }
                        else if (goalLine.StartsWith("Name: "))
                        {
                            goalName = goalLine.Replace("Name: ", "").Trim();
                        }
                        else if (goalLine.StartsWith("Description: "))
                        {
                            goalDescription = goalLine.Replace("Description: ", "").Trim();
                        }
                        else if (goalLine.StartsWith("Goal Points: "))
                        {
                            goalPoints = int.Parse(goalLine.Replace("Goal Points: ", "").Trim());
                        }
                        else if (goalLine.StartsWith("Number of times completed:"))
                        {
                            numOfTimesCompleted = int.Parse(goalLine.Replace("Number of times completed: ", "").Trim());
                        }
                        else if (goalLine.StartsWith("Goal Bonus: "))
                        {
                            goalBonus = int.Parse(goalLine.Replace("Goal Bonus: ", "").Trim());
                        }
                        else if (goalLine.StartsWith("Completed: "))
                        {
                            completed = bool.Parse(goalLine.Replace("Completed: ", "").Trim());
                        }
                        else if (goalLine.StartsWith("Times Required to get bonus: "))
                        {
                            numOfTimesRequired = int.Parse(goalLine.Replace("Times Required to get bonus:", "").Trim());
                        }

                    }
                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, completed);
                        _fileEntries.Add(newSimpleGoal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints, numOfTimesCompleted);
                        _fileEntries.Add(newEternalGoal);
                    }
                    else if (goalType == "CheckListGoal")
                    {
                        CheckListGoal newCheckListGoal = new CheckListGoal(goalName, goalDescription, goalPoints, numOfTimesRequired, goalBonus, numOfTimesCompleted, completed);
                        _fileEntries.Add(newCheckListGoal);
                    }
                    goalLines.Clear(); // empty list
                }
            }


            _goalList = _fileEntries;
        }
    }
    public void AddGoalsToList(Goal goal)
    {
        _goalList.Add(goal);
    }
    public int DisplayPoints() //show the points to the screen
    {
        int totalPoints = 0;
        foreach (Goal goal in _goalList)
        {
            totalPoints += goal.CalculatePoints();
        }
        return totalPoints;
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

    public string DisplayGoalNames()
    {
        string goalNames = "";
        foreach (Goal goal in _goalList)
        {
            int goalIndex = _goalList.IndexOf(goal) + 1;
            goalNames += ($"{goalIndex}. {goal.GetName()}\n\n");
        }
        return goalNames;
    }

    public int RecordEvent(int userIndex)
    {
        return _goalList[userIndex - 1].RecordEvent();

    }

    public string showCompletedGoals()
    {

        string goalNames = "";
        foreach (Goal goal in _goalList)
        {
            int goalIndex = _goalList.IndexOf(goal) + 1;
            string completedBox = "[ ]";
            if (goal.GetCompletedStatus())
            {
                completedBox = "[X]";
            }
            
            goalNames += ($"{goalIndex}. {completedBox} {goal.GetName()} ({goal.GetDescription()}) \n\n");
        }
        return goalNames;
    }
}
