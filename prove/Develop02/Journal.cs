using System;

class Journal
{
    // list of attributes/variables
    public string _fileLocation = "";
    public string _journalName = "";


    // constructing class. 
    public List<Entry> _entries = new List<Entry>();

    // Constructor
    public Journal()
    {

    }

// TODO work on saveto file 
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

    // todo work on load file 

    public string Display()
    {
        List<string> entries = new List<string>();
        foreach (Entry entry in _entries)
        {
           entries.Add( entry.Display() );
        }
        return string.Join('\n', entries);
    }
}