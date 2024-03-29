using System;

public class Lectures : Events

{
protected string _speaker;
protected int _capacity;

public Lectures (string eventTitle, string description, DateOnly date, TimeOnly time, string address, string speaker, int capacity) : base (eventTitle, description, date, time, address)
{
    _speaker = speaker;
    _capacity = capacity;
}


public string GetFullDetails ()
{
    return $"Event: {_eventTitle} \nEvent Description: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address} \nSpeaker: {_speaker} \nCapacity: {_capacity}\n";
    }

}

