using System;

class Journal
{
    // list of attributes/variables
    public string _fileLocation = "";
    public string _journalName = "";

    public string _fileName2 = "";


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
            outputFile.WriteLine($"Journal Name: {_journalName}");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.Display());

            }
        }
    }

    // todo work on load file 

    public List<Entry> loadFile(string fileName)
    {
        using (StreamReader fileText = new StreamReader(fileName))
        {
            string line;
            List<Entry> _readEntries = new List<Entry>();
            Entry readEntry = new Entry();

            while ((line = fileText.ReadLine()) != null)
            {
                Console.WriteLine(line);
                if (line.StartsWith("Date:"))
                {
                    readEntry._date = line.Replace("Date: ", "");
                }
                if (line.StartsWith("Prompt:"))
                {
                    readEntry._prompt = line.Replace("Prompt: ", "");
                }
                if (line.StartsWith("Entry:"))
                {
                    readEntry._userInput = line.Replace("Entry: ", "");
                }
                if (line == "")
                {
                    _readEntries.Add(readEntry);
                }

            };

            _entries = _readEntries;
            return _readEntries;

        }
    }

    public string Display()
    {
        List<string> entries = new List<string>();
        foreach (Entry entry in _entries)
        {
            entries.Add(entry.Display());
        }
        string line = string.Join('\n', entries);
        return line;
    }
}