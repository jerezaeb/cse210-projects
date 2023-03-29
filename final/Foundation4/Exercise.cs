using System;

public abstract class Exercise
{
private DateOnly _date;
private int _duration;

public Exercise (DateOnly date, int duration)
{
    _date = date;
    _duration = duration;
}

public DateOnly date
{
    get {return _date;}
}

public int duration
{
    get {return _duration;}
}
public abstract float GetDistance ();

public abstract float GetSpeed ();

public abstract float GetPace ();

public abstract string GetSummary ();

}