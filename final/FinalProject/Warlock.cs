public class Warlock : SharedCharacterClasses
{
    private string _warlockSkill1;
    // private string _warlockSkill2;
    // private string _warlockSkill3;

    public string GetWarlockSkill()
    {
        return _warlockSkill1;
    }

    public void SetWarlockSkill(int warlockSkill1)
    {
        _warlockSkill1 = _warlockSkills[warlockSkill1 - 1];
    }

    List<string> _warlockSkills = new List<string>(){
        "Eldritch Blast",
        "Pact Magic",
        "Invocations",
        "Otherworldly Patron",
        "Dark One's Blessing"
    };

    public Warlock(string characterName, string race, string background)
    : base(characterName, race, background)
    {
        // Character specific items

    }




    public void DisplaySpecificSkills()
    {
        int num = 1;
        foreach (string skill in _warlockSkills)
        {
            Console.WriteLine($"{num}. {skill}");
            num++;
        }
    }
    public override void DisplayCharacter()
    {
        Console.Clear(); //! this shows things in the base class
        base.DisplayCharacter();
        Console.WriteLine($"");
        Console.WriteLine($"Below are items that are specific to the warlock class");
        Console.WriteLine($"Warlock specific skill: {_warlockSkill1}");
    }

}