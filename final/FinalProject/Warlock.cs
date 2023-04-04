public class Warlock : SharedCharacterClasses
{
    private string _warlockSkill1;

    public string GetWarlockSkill()
    {
        return _warlockSkill1;
    }

    public void SetWarlockSkill(int warlockSkill1)
    {
        _warlockSkill1 = _warlockSkills[warlockSkill1 - 1];
    }

    private List<string> _warlockSkills = new List<string>(){
        "Eldritch Blast",
        "Pact Magic",
        "Invocations",
        "Otherworldly Patron",
        "Dark One's Blessing"
    };

    public Warlock(string characterName, string race, string background)
    : base(characterName, race, background)
    {

    }

    public override void DisplaySpecificSkills()
    {
        SharedCharacterClasses.DisplaySpecificSkillsStatic(_warlockSkills);
    }
    public override void DisplayCharacter()
    {
        Console.Clear();
        base.DisplayCharacter();
        Console.WriteLine($"Warlock specific skill: {_warlockSkill1}\n");
        Console.WriteLine($"Press enter to return to the main menu.");
    }

}