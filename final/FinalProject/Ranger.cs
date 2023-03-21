public class Ranger : SharedCharacterClasses
{

    public Ranger(string characterName, string race, string background, List<string> inventory)
    : base(characterName, race, background, inventory)
    {
        // Character specific items
    }
    private string _rangerSkill1;
    private string _rangerSkill2;
    private string _rangerSkill3;




    public string DisplayRangerTraits()
    {
        return ("");
    }
    public string DisplayRanger()
    {
        return ("welcome to the Ranger class.");
    }
}