public class Ranger : SharedCharacterClasses
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
    private string _rangerSkill1;
    private string _rangerSkill2;
    private string _rangerSkill3;

    public Ranger(string characterName, string race, string background, List<string> inventory)
    : base(characterName, race, background, inventory)
    {
        // Character specific items
    }




    public string DisplayRangerTraits()
    {
        return ("");
    }
    public string DisplayRanger()
    {
        return ("welcome to the Ranger class.");
    }
}