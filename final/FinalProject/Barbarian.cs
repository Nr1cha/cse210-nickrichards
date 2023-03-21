class Barbarian : SharedCharacterClasses
{
    private string _barbarianSkill1 { get; }
    private string _barbarianSkill2 { get; }
    private string _barbarianSkill3 { get; }

    public Barbarian(string characterName, string race, string background, List<string> inventory, string bSkill1, string bSkill2, string bSkill3) //all items to be shown
        : base(characterName, race, background, inventory) /* these are items from the base class */
    {
        // Character specific items
        // these are items that are different than what's in the base class
        _barbarianSkill1 = bSkill1;
        _barbarianSkill2 = bSkill2;
        _barbarianSkill3 = bSkill3;


    }

    public override void DisplayBarbarian()
    {
        base.DisplayBase();
        Console.WriteLine($"Skill 1: {_barbarianSkill1}");
        Console.WriteLine($"Skill 2: {_barbarianSkill2}");
        Console.WriteLine($"Skill 3: {_barbarianSkill3}");
    }
    // public string DisplayBarbarian()
    // {
    //     return ("welcome to the barbarian class.");
    // }
}