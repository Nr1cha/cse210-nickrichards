public class Bard : SharedCharacterClasses
{


    private string _bardSkill1;

    public string GetBardSkill()
    {
        return _bardSkill1;
    }
    public void SetBardSkill(int bardSkill1)
    {
        _bardSkill1 = _bardSkills[bardSkill1 - 1];
    }


    private List<string> _bardSkills = new List<string>(){
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

    }
    public override void DisplaySpecificSkills()
    {
        SharedCharacterClasses.DisplaySpecificSkillsStatic(_bardSkills);
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