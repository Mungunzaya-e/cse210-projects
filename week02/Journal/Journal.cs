using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }

    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the name of your file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the name of your file?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('~');

            Entry entry = new Entry();

            entry._date = parts[0].Trim();
            entry._randomPrompt = parts[1].Trim();
            entry._entryText = parts[2].Trim();

            _entries.Add(entry);

        }
    }

    public int GetTotalCharacterCount()
    {
        int total = 0;
        foreach (Entry entry in _entries)
        {
            total += entry._entryText.Length;
        }

        return total;
    }
}