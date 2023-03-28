public class Swimming: Exercise
{
    private int _numberOfLaps;

    public Swimming (string date, int duration, int numberOfLaps): base (date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override int GetDistance ();

    public override float GetSpeed ();

    public override float GetSpace ();

    public override string GetSummary ();   
    
}