public class Wizard : SharedCharacterClasses
{
    private string _wizardSkill1;
    // private string _wizardSkill2;
    // private string _wizardSkill3;

    public string GetWizardSkill()
    {
        return _wizardSkill1;
    }
    public void SetWizardSkill(int wizardSkill1)
    {
        _wizardSkill1 = _wizardSkills[wizardSkill1 - 1];
    }
    List<string> _wizardSkills = new List<string>(){
        "Arcana",
        "Spellcasting",
        "Ritual Casting",
        "Arcane Recovery",
        "Spell Mastery"
    };


    public Wizard(string characterName, string race, string background)
    : base(characterName, race, background)
    {
        // Character specific items

    }




    public void DisplaySpecificSkills()
    {
        int num = 1;
        foreach (string skill in _wizardSkills)
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
        Console.WriteLine($"Below are items that are specific to the wizard class");
        Console.WriteLine($"Wizard specific skill: {_wizardSkill1}");
    }
}