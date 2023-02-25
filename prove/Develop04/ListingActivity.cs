public class ListingActivity : Activity
{
    string _userInputListing;
    public ListingActivity(string activityName, string activityDescription)
        : base(activityName, activityDescription)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity\n");
        Console.WriteLine("");
    }
}
