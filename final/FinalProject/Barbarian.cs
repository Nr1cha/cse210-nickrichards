public class Barbarian : SharedCharacterClasses
{
    private string _barbarianS1;

    public string GetBarbarianSkill()
    {
        return _barbarianS1;
    }
    public void SetBarbarianSkill(int barbarianS1)
    {
        _barbarianS1 = _barbarianSkills[barbarianS1 - 1];
    }

    private List<string> _barbarianSkills = new List<string>() {
        "Rage",
        "Unarmored Defense",
        "Reckless Attack",
        "Danger Sense",
        "Feral Instinct",
        "Brutal Critical",
        "Primal Path"
    };    

    public Barbarian(string characterName, string race, string background)
        : base(characterName, race, background)
    {

    }

    public override void DisplaySpecificSkills()
    {
        SharedCharacterClasses.DisplaySpecificSkillsStatic(_barbarianSkills);
    }
    public override void DisplayCharacter()
    {
        Console.Clear();
        base.DisplayCharacter();
        Console.WriteLine($"");
        Console.WriteLine($"Below are items that are specific to the barbarian class");
        Console.WriteLine($"Barbarian specific skill: {_barbarianS1}");
    }
}