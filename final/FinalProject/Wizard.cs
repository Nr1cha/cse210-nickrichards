public class Wizard : SharedCharacterClasses
{


    public Wizard(string characterName, string race, string background, List<string> inventory)
    : base(characterName, race, background, inventory)
    {
        // Character specific items

    }
    private string _wizardSkill1;
    private string _wizardSkill2;
    private string _wizardSkill3;





    public string DisplayWizardTraits()
    {
        return ("");
    }
    public string DisplayWizard()
    {
        return ("welcome to the Wizard class.");
    }
}