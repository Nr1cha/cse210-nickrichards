public class Bard : SharedCharacterClasses
{

    public Bard(string characterName, string race, string background, List<string> inventory)
    : base(characterName, race, background, inventory)
    {
        // Character specific items

    }
    private string _bardSkill1;
    private string _bardSkill2;
    private string _bardSkill3;



    public string DisplayBardTraits()
    {
        return ("");
    }
    public string DisplayBard()
    {
        return ("welcome to the Bard class.");
    }
}