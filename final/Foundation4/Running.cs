using System;
public class Running: Exercise
{
    private int _distance;

    public Running (DateOnly date, int duration, int distance): base (date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()

    {
        return (GetDistance()/duration) *60;
    }

    //public override float GetPace()
    //{
     //   return  duration / GetDistance();
    //}

    
    
}