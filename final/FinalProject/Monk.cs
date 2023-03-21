public class Monk : SharedCharacterClasses
{

    public Monk(string characterName, string race, string background, List<string> inventory)
    : base(characterName, race, background, inventory)
    {
        // Character specific items

    }
    private string _monkSkill1;
    private string _monkSkill2;
    private string _monkSkill3;



    public string DisplayMonkTraits()
    {
        return ("");
    }
    public string DisplayMonk()
    {
        return ("welcome to the Monk class.");
    }
}