public class Barbarian : SharedCharacterClasses
{
    private string _barbarianS1 { get; set; }
    // private string BarbarianSkill2 { get; set; }
    // private string BarbarianSkill3 { get; set; }

    public string GetBarbarianSkill()
    {
        return _barbarianS1;
    }
    public void SetBarbarianSkill(int barbarianS1)
    {
        _barbarianS1 = _barbarianSkills[barbarianS1 - 1];
    }

    private List<string> _barbarianSkills = new List<string>() {
        "1. Rage",
        "2. Unarmored Defense",
        "3. Reckless Attack",
        "4. Danger Sense",
        "5. Feral Instinct",
        "6. Brutal Critical",
        "7. Primal Path"
    };

    Random rand = new Random();
    

    public Barbarian(string characterName, string race, string background, List<string> inventory) //all items to be shown
        : base(characterName, race, background, inventory) // what its going to show from the base class
    {
        // Character specific items
        // these are items that are different than what's in the base class


    }

    public void DisplaySpecificSkills()
    {
        foreach(string skill in _barbarianSkills)
        {
            Console.WriteLine($"{skill}");
        }
    }
    public override void DisplayCharacter()
    {
        Console.Clear();
        base.DisplayCharacter();
        // Console.WriteLine(dndSkills[test]);
        // Console.WriteLine($"test item from derived class barbarian");
        Console.WriteLine($"barbarian specific skill: {_barbarianS1}");
        // Console.WriteLine($"Skill 3: {dndSkills[test]}");

    }
}