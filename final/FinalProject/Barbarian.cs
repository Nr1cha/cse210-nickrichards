public class Barbarian : SharedCharacterClasses
{
    private string _barbarianSkill1 { get; set; }
    // private string BarbarianSkill2 { get; set; }
    // private string BarbarianSkill3 { get; set; }

    List<string> _barbarianSkills = new List<string>() {
        "Rage",
        "Unarmored Defense",
        "Reckless Attack",
        "Danger Sense",
        "Feral Instinct",
        "Brutal Critical",
        "Primal Path"
    };

    Random rand = new Random();

    public Barbarian(string characterName, string race, string background, List<string> inventory) //all items to be shown
        : base(characterName, race, background, inventory)
    {
        // Character specific items
        // these are items that are different than what's in the base class
    }
    public override void DisplayCharacter()
    {
        base.DisplayCharacter();
        
        Console.WriteLine($"{_barbarianSkill1}");
        // Console.WriteLine(dndSkills[test]);
        // Console.WriteLine($"Skill 2: {dndSkills[test]}");
        // Console.WriteLine($"Skill 3: {dndSkills[test]}");

    }
}