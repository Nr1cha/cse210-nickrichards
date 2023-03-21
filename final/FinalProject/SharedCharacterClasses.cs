public class SharedCharacterClasses
{
    private string _characterName {get; set;}
    private string _race {get; set;}
    private string _background {get; set;}
    private List<string> _inventory {get; set;}




public SharedCharacterClasses(string characterName, string race, string background, List<string> inventory )
{
    _characterName = characterName;
    _race = race;
    _background = background;
    _inventory = inventory;
}

public void AddToInventory(string item)
{
    _inventory.Add(item);
}

public void RemoveFromInventory(string item)
{
    _inventory.Remove(item);
}


}