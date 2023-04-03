public class Cleric : SharedCharacterClasses
{
    private string _clericSkill1;
    // private string _clericSkill2;
    // private string _clericSkill3;

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
        // Character specific items

    }

    public void DisplaySpecificSkills()
    {
        int num = 1;
        foreach (string skill in _clericSkills)
        {
            Console.WriteLine($"{num}. {skill}");
            num++;
        }
    }


    public string DisplayClericTraits()
    {
        return ("");
    }
    public string DisplayCleric()
    {
        return ("welcome to the Cleric class.");
    }
}