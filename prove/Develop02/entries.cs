using System;
class Entry
{
    public string Text { get; set; }
    public DateTime Date { get; set; }

    public Entry(string text, DateTime date)
    {
        Text = text;
        Date = date;
    }
}