public class Cleric : SharedCharacterClasses
{
    private string _clericSkill1;

    public string GetClericSkill()
    {
        return _clericSkill1;
    }

    public void SetClericSkill(int claricSkill1)
    {
        _clericSkill1 = _clericSkills[claricSkill1 - 1];
    }

    List<string> _clericSkills = new List<string>() {
        "Channel Divinity",
        "Spellcasting",
        "Divine Domain",
        "Destroy Undead",
        "Divine Intervention",
        "Turn Undead",
        "Channel Divinity: Divine Strike"
    };

    public Cleric(string characterName, string race, string background)
        : base(characterName, race, background)
    {

    }

    public override void DisplaySpecificSkills()
    {
        SharedCharacterClasses.DisplaySpecificSkillsStatic(_clericSkills);
    }
    public override void DisplayCharacter()
    {
        Console.Clear();
        base.DisplayCharacter();
        Console.WriteLine($"Cleric specific skill: {_clericSkill1}\n");
        Console.WriteLine($"Press enter to return to the main menu.");
    }
}