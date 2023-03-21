public class Cleric : SharedCharacterClasses
{

    public Cleric(string characterName, string race, string background, List<string> inventory)
        : base(characterName, race, background, inventory)
    {
        // Character specific items

    }
    private string _clericSkill1;
    private string _clericSkill2;
    private string _clericSkill3;




    public string DisplayClericTraits()
    {
        return ("");
    }
    public string DisplayCleric()
    {
        return ("welcome to the Cleric class.");
    }
}