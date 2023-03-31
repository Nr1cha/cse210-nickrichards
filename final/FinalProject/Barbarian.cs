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
        "Rage",
        "Unarmored Defense",
        "Reckless Attack",
        "Danger Sense",
        "Feral Instinct",
        "Brutal Critical",
        "Primal Path"
    };

    Random rand = new Random();
    

    public Barbarian(string characterName, string race, string background) //all items to be shown
        : base(characterName, race, background) // what its going to show from the base class
    {
        // Character specific items
        // these are items that are different than what's in the base class


    }

    public void DisplaySpecificSkills()
    {
        int num = 1;
        foreach(string skill in _barbarianSkills)
        {
            Console.WriteLine($"{num}. {skill}");
            num++;
        }
    }
    public override void DisplayCharacter() //!random skill from base
    {
        Console.Clear();
        base.DisplayCharacter();
        Console.WriteLine($"");
        Console.WriteLine($"barbarian specific skill: {_barbarianS1}");
    }
}