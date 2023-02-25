public class ReflectingActivity : Activity
{
    string _userInputReflecting;
    public ReflectingActivity(string activityName, string activityDescription)
        : base(activityName, activityDescription)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity");
        return;
    }

}
