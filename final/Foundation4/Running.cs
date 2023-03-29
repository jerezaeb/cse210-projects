using System;
public class Running: Exercise
{
    private int _distance;

    public Running (DateOnly date, int duration, int distance): base (date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance ()
    {
        return _distance;
    }

    public override float GetSpeed ()

    {
        return  _distance / (duration / 60);
    }

    public override float GetPace()
    {
        return  (duration / 60) /_distance;
    }

    public override string GetSummary () 
    {
        return $" {date} Running ({duration}min) - Distance {_distance}km, Speed: {GetSpeed}Kmph, Pace: {GetPace}min per Km ";
    }
    
}