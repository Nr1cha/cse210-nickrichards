public class Wizard : SharedCharacterClasses
{
    private string _wizardSkill1;
    private string _wizardSkill2;
    private string _wizardSkill3;

    List<string> wizardSkills = new List<string>(){
        "Arcana",
        "Spellcasting",
        "Ritual Casting",
        "Arcane Recovery",
        "Spell Mastery"
    };


    public Wizard(string characterName, string race, string background, List<string> inventory)
    : base(characterName, race, background, inventory)
    {
        // Character specific items

    }





    public string DisplayWizardTraits()
    {
        return ("");
    }
    public string DisplayWizard()
    {
        return ("welcome to the Wizard class.");
    }
}