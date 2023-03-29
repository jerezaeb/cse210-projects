public class Swimming: Exercise
{
    private int _numberOfLaps;

    public Swimming (DateOnly date, int duration, int numberOfLaps): base (date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float GetDistance ()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override float GetSpeed ()
    {
        return GetDistance()/(duration/60);
    }
    public override float GetPace ()
    {
        return (duration / GetDistance()) / 60;
    }

    public override string GetSummary ()
    {
        return $" {date} Swimming ({duration}min) -Number Of Laps: {_numberOfLaps}km, Distance: {GetDistance} Speed: {GetSpeed}Kmph, Pace: {GetPace}min per Km ";
    }
}