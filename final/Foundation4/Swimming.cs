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
        return (GetDistance()/duration) *60;
    }

}