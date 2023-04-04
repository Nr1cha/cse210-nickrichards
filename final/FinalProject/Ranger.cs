public class Ranger : SharedCharacterClasses
{
    private string _rangerSkill1;

    public string GetRangerSkill()
    {
        return _rangerSkill1;
    }
    public void SetRangerSkill(int rangerSkill1)
    {
        _rangerSkill1 = _rangerSkills[rangerSkill1 - 1];
    }

    private List<string> _rangerSkills = new List<string>(){
        "Favored Enemy",
        "Natural Explorer",
        "Primeval Awareness",
        "Spellcasting",
        "Fighting Style",
        "Hunter's Prey"
    };

    public Ranger(string characterName, string race, string background)
    : base(characterName, race, background)
    {

    }

    public override void DisplaySpecificSkills()
    {
        SharedCharacterClasses.DisplaySpecificSkillsStatic(_rangerSkills);
    }
    public override void DisplayCharacter()
    {
        Console.Clear(); //! this shows things in the base class
        base.DisplayCharacter();
        Console.WriteLine($"");
        Console.WriteLine($"Below are items that are specific to the ranger class");
        Console.WriteLine($"Ranger specific skill: {_rangerSkill1}");
    }
}