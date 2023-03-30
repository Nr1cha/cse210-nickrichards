public class Bard : SharedCharacterClasses
{


    private string _bardSkill1;
    private string _bardSkill2;
    private string _bardSkill3;


    List<string> _bardSkills = new List<string>(){
        "Bardic Inspiration",
        "Spellcasting",
        "Jack of All Trades",
        "Song of Rest",
        "Expertise",
        "Countercharm",
        "Magical Secrets"
    };


    public Bard(string characterName, string race, string background, List<string> inventory)
    : base(characterName, race, background, inventory)
    {
        // Character specific items

    }



    public string DisplayBardTraits()
    {
        return ("");
    }
    public string DisplayBard()
    {
        return ("welcome to the Bard class.");
    }
}