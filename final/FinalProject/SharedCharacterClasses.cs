public class SharedCharacterClasses
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
    private string _characterName { get; set; }
    private string _race { get; set; }
    private string _background { get; set; }
    private List<string> _inventory { get; set; }
    private string _skill1 {get; set;}

    Random rand = new Random();
    public SharedCharacterClasses(string characterName, string race, string background, List<string> inventory)
    {
        _characterName = characterName;
        _background = background;
        _race = race;
        _inventory = inventory;
        int test = rand.Next(dndSkills.Count);
        _skill1 = dndSkills[test];
    }


    public virtual void DisplayCharacter()
    {
        Console.WriteLine($"Character Name: {_characterName}");
        Console.WriteLine($"Background: {_background}");
        Console.WriteLine($"Race: {_race}");
        Console.WriteLine($"Inventory: {_inventory}");
        Console.WriteLine($"Skill 1: {_skill1}");
    }

    // public void AddToInventory(string item)
    // {
    //     _inventory.Add(item);
    // }

    // public void RemoveFromInventory(string item)
    // {
    //     _inventory.Remove(item);
    // }


}