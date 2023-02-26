public class ListingActivity : Activity
{
    // string _userInputListing;
    private List<string> _userList = new List<string>();
    private List<string> _randomPromptList = new List<string>();

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
        _randomPromptList.Add("Who are people that you appreciate?");
        _randomPromptList.Add("What are personal strengths of yours?");
        _randomPromptList.Add("Who are people that you have helped this week?");
        _randomPromptList.Add("When have you felt the Holy Ghost this month?");
        _randomPromptList.Add("Who are some of your personal heroes?");
    }

    private int getNowtime()
    {
        TimeSpan nowTime = DateTime.UtcNow - new DateTime(1970, 1, 1);
        int timeThing = (int)nowTime.TotalSeconds;
        return timeThing;
    }

    public void List() //METHOD, NOT RETURNING ANYTHING
    {
        Console.Clear();
        base.WelcomeMessage();
        Console.WriteLine("Get ready...\n");
        base.Animation(5);

        Console.WriteLine("List as many responses you can to the following prompt:");
        // random prompt
        Random random = new Random();
        int startListIndex = random.Next(0, _randomPromptList.Count);
        string startListMesssage = _randomPromptList[startListIndex];
        Console.WriteLine(startListMesssage);
        base.Timer(5);
        int stopTime = getNowtime() + base.getDuration();
        while (getNowtime() < stopTime)
        {
            Console.Write("> ");
            string userListInput = Console.ReadLine();
            _userList.Add(userListInput);
        }
        Console.WriteLine($"You listed {_userList.Count} items!");
        base.endingMessage();





    }
}
