public class SharedCharacterClasses
{
    private List<string> _dndInventoryItem = new List<string>() {
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

    private List<string> _dndSkills = new List<string>() {
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

    // private List<string> _dndSavingThrows = new List<string>() {
    //         "Strength",
    //         "Dexterity",
    //         "Constitution",
    //         "Inteligence",
    //         "Wisdom",
    //         "Charisma",
    //     };

    // private List<string> _dndAbilities = new List<string>() {
    //         "Strength",
    //         "Dexterity",
    //         "Constitution",
    //         "Intelligence",
    //         "Wisdom",
    //         "Charisma",
    //     };

    private List<string> _characterSkill = new List<string>();

    private string _characterName { get; set; }
    private string _race { get; set; }
    private string _background { get; set; }
    private string _inventoryItem { get; set; }
    private string _skill1 { get; set; }
    private string _specificSkill { get; set; }

    Random rand = new Random();
    public SharedCharacterClasses(string characterName, string race, string background)
    {
        _characterName = characterName;
        _background = background;
        _race = race;

        int skillIndex = rand.Next(_dndSkills.Count);
        _skill1 = _dndSkills[skillIndex];

        int inventoryIndex = rand.Next(_dndInventoryItem.Count);
        _inventoryItem = _dndInventoryItem[inventoryIndex];
    }


    public virtual void DisplayCharacter()
    {
        Console.WriteLine($"Character Name: {_characterName}");
        Console.WriteLine($"Background: {_background}");
        Console.WriteLine($"Race: {_race}\n");
        Console.WriteLine($"Below are items that any character can start with at random");
        Console.WriteLine($"Inventory Item(s): {_inventoryItem}");
        Console.WriteLine($"Universal Skill: {_skill1}");
    }

    public virtual void DisplaySpecificSkills()
    {
        DisplaySpecificSkillsStatic(_characterSkill);
    }

    public static void DisplaySpecificSkillsStatic(List<string> skills)
    {
        int num = 1;
        foreach (string skill in skills)
        {
            Console.WriteLine($"{num}. {skill}");
            num++;
        }
    }

}