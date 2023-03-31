public class Druid : SharedCharacterClasses
{
    private string _druidSkill1;
    private string _druidSkill2;
    private string _druidSkill3;

    List<string> _druidSkills = new List<string>() {
        "Druidic",
        "Spellcasting",
        "Wild Shape",
        "Circle Forms",
        "Natural Recovery",
        "Land's Stride",
        "Timeless Body",
        "Beast Spells",
        "Archdruid (capstone ability)"
    };

    public Druid(string characterName, string race, string background)
    : base(characterName, race, background)
    {
        // Character specific items

    }





    public string DisplayDruidTraits()
    {
        return ("");
    }
    public string DisplayDruid()
    {
        return ("welcome to the Druid class.");
    }
}