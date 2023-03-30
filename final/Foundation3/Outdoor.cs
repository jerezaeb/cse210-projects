using System;

public class Outdoor : Events

{
protected string _weather;

public Outdoor (string eventTitle, string description, DateOnly date, TimeOnly time, string address, string weather) : base (eventTitle, description, date, time, address)
{
    _weather = weather;
  
}


public string GetFullDetails ()
{
    return $"Event: {_eventTitle} \nEvent Description: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address} \nWeather: {_weather}\n";
    }

}

