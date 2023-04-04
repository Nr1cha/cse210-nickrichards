public class Wizard : SharedCharacterClasses
{
    private string _wizardSkill1;

    public string GetWizardSkill()
    {
        return _wizardSkill1;
    }
    public void SetWizardSkill(int wizardSkill1)
    {
        _wizardSkill1 = _wizardSkills[wizardSkill1 - 1];
    }
    private List<string> _wizardSkills = new List<string>(){
        "Arcana",
        "Spellcasting",
        "Ritual Casting",
        "Arcane Recovery",
        "Spell Mastery"
    };

    public Wizard(string characterName, string race, string background)
    : base(characterName, race, background)
    {

    }

    public override void DisplaySpecificSkills()
    {
        SharedCharacterClasses.DisplaySpecificSkillsStatic(_wizardSkills);
    }
    public override void DisplayCharacter()
    {
        Console.Clear();
        base.DisplayCharacter();
        Console.WriteLine($"");
        Console.WriteLine($"Below are items that are specific to the wizard class");
        Console.WriteLine($"Wizard specific skill: {_wizardSkill1}");
    }
}