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
    private string _inventory { get; set; }
    private string _skill1 {get; set;}

    Random rand = new Random();
    public SharedCharacterClasses(string characterName, string race, string background)
    {
        _characterName = characterName;
        _background = background;
        _race = race;

        // * random skill from base class
        int skillIndex = rand.Next(dndSkills.Count);
        _skill1 = dndSkills[skillIndex];

        // todo inventory item from inventory list
        int inventoryIndex = rand.Next(dndInventory.Count);
        _inventory = dndInventory[inventoryIndex];

    }


    public virtual void DisplayCharacter()
    {
        Console.WriteLine($"Character Name: {_characterName}");
        Console.WriteLine($"Background: {_background}");
        Console.WriteLine($"Race: {_race}\n");
        Console.WriteLine($"Below are items that any character can start with at random");
        Console.WriteLine($"Inventory: {_inventory}");
        Console.WriteLine($"Universal Skill: {_skill1}");
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