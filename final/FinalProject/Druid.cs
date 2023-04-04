public class Druid : SharedCharacterClasses
{
    private string _druidSkill1;

    public string GetDruidSkill()
    {
        return _druidSkill1;
    }

    public void SetDruidSkill(int druidSkill1)
    {
        _druidSkill1 = _druidSkills[druidSkill1 - 1];
    }

    private List<string> _druidSkills = new List<string>() {
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

    }

    public override void DisplaySpecificSkills()
    {
        SharedCharacterClasses.DisplaySpecificSkillsStatic(_druidSkills);
    }
    public override void DisplayCharacter()
    {
        Console.Clear();
        base.DisplayCharacter();
        Console.WriteLine($"");
        Console.WriteLine($"Below are items that are specific to the druid class");
        Console.WriteLine($"Druid specific skill: {_druidSkill1}");
    }
}