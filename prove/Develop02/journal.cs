using System;
class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string text)
    {
        var entry = new Entry(text, DateTime.Now);
        entries.Add(entry);
    }

    public void LoadFromFile(string path)
    {
        entries = File.ReadAllLines(path)
            .Select(x => new Entry(x, DateTime.Now))
            .ToList();
    }

    public void SaveToFile(string path)
    {
        File.WriteAllLines(path, entries.Select(x => x.Text));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.Text);
            Console.WriteLine("Date: " + entry.Date);
        }
    }
}
