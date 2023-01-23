using System;

class Journal
{
    // list of attributes/variables
    public string _fileLocation = "";
    public string _journalName = "";

    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        
    }

    public void saveFile(string filePath)
    {
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            outputFile.WriteLine($"{_journalName}");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.Display());

            }
        }
    }

    public void Display()
    {
        // Console.WriteLine($"{}");
    }


}