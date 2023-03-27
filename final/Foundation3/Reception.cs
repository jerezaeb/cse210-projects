using System;

public class Reception : Events

{
protected string _rsvpEmail;

public Reception (string eventTitle, string description, DateOnly date, TimeOnly time, string address, string rsvpEmail) : base (eventTitle, description, date, time, address)
{
    _rsvpEmail = rsvpEmail;
  
}

public string GetStandardDetails ()
    {
    return $"\nEvent: {_eventTitle} \nEvent Description: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address}";
    }
public string GetFullDetails ()
{
    return $"\nEvent: {_eventTitle} \nEvent Description: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address} \nRSVP: {_rsvpEmail} \n ";
    }
public string GetShortDescription ()
{
    return $"Reception Event \nTitle: {_eventTitle} \nDate: {_date}\n";
}
}

