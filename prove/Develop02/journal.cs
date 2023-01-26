using System;
using System.IO;

class Journal
{
    private List<string> entries;

    public Journal()
    {
        entries = new List<string>();
    }

    public void AddEntry(string entry)
    {
        entries.Add(entry);
    }

    public void Save(string filePath)
    {
        File.WriteAllLines(filePath, entries);
    }

    public void Load(string filePath)
    {
        entries = new List<string>(File.ReadAllLines(filePath));
    }

    public void DisplayEntries()
    {
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
}

