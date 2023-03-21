public class Barbarian : SharedCharacterClasses
{
    public string BarbarianSkill1 { get; private set; }
    public string BarbarianSkill2 { get; private set; }
    public string BarbarianSkill3 { get; private set; }

    public Barbarian(string characterName, string race, string background, List<string> inventory, string bSkill1, string bSkill2, string bSkill3) //all items to be shown
        : base(characterName, race, background, inventory)
    {
        // Character specific items
        // these are items that are different than what's in the base class
        BarbarianSkill1 = bSkill1;
        BarbarianSkill2 = bSkill2;
        BarbarianSkill3 = bSkill3;


    }

    public override void DisplayCharacter()
    {
        base.DisplayCharacter();
        Console.WriteLine($"Skill 1: {BarbarianSkill1}");
        Console.WriteLine($"Skill 2: {BarbarianSkill2}");
        Console.WriteLine($"Skill 3: {BarbarianSkill3}");
    }
}