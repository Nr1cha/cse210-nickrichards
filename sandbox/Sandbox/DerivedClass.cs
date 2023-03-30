public class DerivedClass : BaseClass
{

    public DerivedClass(string firstName, string lastName) // the total of what i want to display
        : base(firstName, lastName) //what i'm borrowing from the base
    {

    }
    public override void DisplayName() // how i want to display it
    {
        base.DisplayName("Nick", "richards"); //hello nick
    }
}
