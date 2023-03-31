public class Bard : SharedCharacterClasses
{


    private string _bardSkill1;
    // private string _bardSkill2;
    // private string _bardSkill3;

    public string GetBardSkill()
    {
        return _bardSkill1;
    }
    public void SetBarbarianSkill(int bardSkill1)
    {
        _bardSkill1 = _bardSkills[bardSkill1 - 1];
    }


    List<string> _bardSkills = new List<string>(){
        "Bardic Inspiration",
        "Spellcasting",
        "Jack of All Trades",
        "Song of Rest",
        "Expertise",
        "Countercharm",
        "Magical Secrets"
    };


    public Bard(string characterName, string race, string background)
    : base(characterName, race, background)
    {
        // Character specific items

    }



    public void DisplaySpecificSkills()
    {
        int num = 1;
        foreach (string skill in _bardSkills)
        {
            Console.WriteLine($"{num}. {skill}");
            num++;
        }
    }
    public override void DisplayCharacter() //!random skill from base for this class
    {
        Console.Clear(); //! this shows things in the base class
        base.DisplayCharacter();
        Console.WriteLine($"");
        Console.WriteLine($"Below are items that are specific to the bard class");
        Console.WriteLine($"Barbarian specific skill: {_bardSkill1}");
    }
}