public class Barbarian : SharedCharacterClasses
{
            List<string> dndInventory = new List<string>() {
            "Potion of Healing",
            "Torch",
            "Climbing Gear",
            "Grappling Hook",
            "Spyglass",
            "Lockpicks",
            "Shovel",
            "Lantern",
            "Waterskin",
            "Flint and Steel",
            "Bedroll",
            "Quill and Ink",
            "Spellbook",
            "Potion of Invisibility",
            "Antitoxin",
            "Wand of Magic Missiles",
            "Ring of Protection",
            "Cloak of Elvenkind",
            "Bag of Tricks",
            "Portable Ram",
            "Decanter of Endless Water",
            "Immovable Rod"
        };

        List<string> dndSkills = new List<string>() {
            "Acrobatics",
            "Animal Handling",
            "Arcana",
            "Athletics",
            "Deception",
            "History",
            "Insight",
            "Intimidation",
            "Investigation",
            "Medicine",
            "Nature",
            "Perception",
            "Performance",
            "Persuasion",
            "Religion",
            "Sleight of Hand",
            "Stealth",
            "Survival"
        };

        List<string> dndSavingThrows = new List<string>() {
            "Strength",
            "Dexterity",
            "Constitution",
            "Inteligence",
            "Wisdom",
            "Charisma",
        };

        List<string> dndAbilities =new List<string>() {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma",
        };
    private string BarbarianSkill1 { get; set; }
    private string BarbarianSkill2 { get; set; }
    private string BarbarianSkill3 { get; set; }

    public Barbarian(string characterName, string race, string background, List<string> inventory, string bSkill1, string bSkill2, string bSkill3) //all items to be shown
        : base(characterName, race, background, inventory)
    {
        // Character specific items
        // these are items that are different than what's in the base class
        BarbarianSkill1 = bSkill1;

    }

    public override void DisplayCharacter()
    {
        base.DisplayCharacter();
        Console.WriteLine($"Skill 1: {BarbarianSkill1}");

    }
}