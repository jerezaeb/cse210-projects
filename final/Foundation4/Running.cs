
public class Running: Exercise
{
    private int _distance;

    public Running (string date, int duration, int distance): base (date, duration)
    {
        _distance = distance;
    }

    public override int GetDistance ()
    {
        return _distance;
    }

    public override float GetSpeed ()

    {
        return  _distance / (duration / 60);
    }

    public override float GetPace ()
    {
        return  (duration / _distance)/60;
    }

    public override string GetSummary () 
    {
        return $" Ran {_distance}km in {duration} "
    }
    
}