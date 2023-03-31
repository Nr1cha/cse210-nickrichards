public class Warlock : SharedCharacterClasses
{
    private string _warlockSkill1;
    private string _warlockSkill2;
    private string _warlockSkill3;

    List<string> warlockSkills = new List<string>(){
        "Eldritch Blast",
        "Pact Magic",
        "Invocations",
        "Otherworldly Patron",
        "Dark One's Blessing"
    };

    public Warlock(string characterName, string race, string background)
    : base(characterName, race, background)
    {
        // Character specific items

    }




    public string DisplayWarlockTraits()
    {
        return ("");
    }
    public string DisplayWarlock()
    {
        return ("welcome to the Warlock class.");
    }

}