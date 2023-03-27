using System;
public class Events
{

protected string _eventTitle;
protected string _description;

protected DateOnly _date;

protected TimeOnly _time;

protected string _address;
public Events (string eventTitle, string description, DateOnly date, TimeOnly time, string address)
{
    _eventTitle = eventTitle;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
}

}