using System;
class Entry
{
    public string _writeEntry {get; set;}
    public DateTime _dateTime {get; set;}

    public Entry (string Text, DateTime Date)
    {
        _writeEntry = Text;
        _dateTime = Date;


    }
}