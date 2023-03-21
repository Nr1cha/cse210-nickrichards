public class Barbarian : SharedCharacterClasses
{

    public Barbarian(string characterName, string race, string background, List<string> inventory)
        : base(characterName, race, background, inventory)
        {
        // Character specific items

        }
    private string _barbarianSkill1;
    private string _barbarianSkill2;
    private string _barbarianSkill3;

    public string DisplayBarbarianTraits()
    {
        return ("");
    }
    public string DisplayBarbarian()
    {
        return ("welcome to the barbarian class.");
    }
}