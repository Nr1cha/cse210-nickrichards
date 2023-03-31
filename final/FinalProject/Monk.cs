public class Monk : SharedCharacterClasses
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
    private string _monkSkill1;
    private string _monkSkill2;
    private string _monkSkill3;

    public Monk(string characterName, string race, string background)
    : base(characterName, race, background)
    {
        // Character specific items

    }



    public string DisplayMonkTraits()
    {
        return ("");
    }
    public string DisplayMonk()
    {
        return ("welcome to the Monk class.");
    }
}