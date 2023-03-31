public class Ranger : SharedCharacterClasses
{
    private string _rangerSkill1;
    private string _rangerSkill2;
    private string _rangerSkill3;

    List<string> rangerSkills = new List<string>(){
        "Favored Enemy",
        "Natural Explorer",
        "Primeval Awareness",
        "Spellcasting",
        "Fighting Style",
        "Hunter's Prey"
    };

    public Ranger(string characterName, string race, string background)
    : base(characterName, race, background)
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