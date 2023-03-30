public class BaseClass
{
    private string _firstName;
    private string _lastName;


    public BaseClass(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }



    public virtual void DisplayName()
    {
        Console.WriteLine($"Hello {_firstName} {_lastName}. ");
    }
}
