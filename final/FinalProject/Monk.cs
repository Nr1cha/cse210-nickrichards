public class Monk : SharedCharacterClasses
{

    private string _monkSkill1;
    // private string _monkSkill2;
    // private string _monkSkill3;

    public string GetMonkSkill()
    {
        return _monkSkill1;
    }
    public void SetMonkSkill(int monkSkill1)
    {
        _monkSkill1 = _monkSkills[monkSkill1 - 1];
    }

    List<string> _monkSkills = new List<string>() {
        "Unarmored Defense",
        "Martial Arts",
        "Ki",
        "Unarmored Movement",
        "Deflect Missiles",
        "Slow Fall",
        "Stunning Strike",
        "Evasion",
        "Stillness of Mind",
        "Diamond Soul"
    };

    public Monk(string characterName, string race, string background)
    : base(characterName, race, background)
    {
        // Character specific items

    }



    public void DisplaySpecificSkills()
    {
        int num = 1;
        foreach (string skill in _monkSkills)
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
        Console.WriteLine($"Below are items that are specific to the monk class");
        Console.WriteLine($"Monk specific skill: {_monkSkill1}");
    }
}