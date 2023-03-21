public class Druid : SharedCharacterClasses
{

    public Druid(string characterName, string race, string background, List<string> inventory)
    : base(characterName, race, background, inventory)
    {
        // Character specific items

    }
    private string _druidSkill1;
    private string _druidSkill2;
    private string _druidSkill3;





    public string DisplayDruidTraits()
    {
        return ("");
    }
    public string DisplayDruid()
    {
        return ("welcome to the Druid class.");
    }
}