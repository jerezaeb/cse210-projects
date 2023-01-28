using System;

class Journal

{
    public List <Entry> _journalEntries = new List<Entry>();

    public void AddEntry(string entries)
    {
        var entry = new Entry (entries, DateTime.Now);
        _journalEntries.Add(entry);
    }

    public void LoadFromFile (string _fileName)
    {
        _journalEntries = File.ReadAllLines(_fileName)
           .Select(x => new Entry (x, DateTime.Now))
           .ToList();
    }
    public void SaveToFile (string _fileName)
    {
        File.WriteAllLines (_fileName, _journalEntries.Select (x=> x._writeEntry));
    }

    public void DisplayEntries()
    {
        foreach (var entry in _journalEntries)
        Console.WriteLine (entry._writeEntry);
        Console.WriteLine("Date: " + DateTime.Now);
    }
}