public class Cycling: Exercise
{
    private float _speed;
    private double v;

    public Cycling (DateOnly date, int duration, float speed): base (date, duration)
    {
        _speed = speed;
    }

    public Cycling(DateOnly date, int duration, double v) : base(date, duration)
    {
    }

    public override float GetDistance ()
    {
        return _speed * (duration / 60);
    }
     public override float GetSpeed ()
    {
        return _speed;
    }

    public override float GetPace (){
        return 60 / GetSpeed();
    }

    public override string GetSummary () 

    {
        return $" {date} Cycling ({duration}min) -Speed: {_speed}Kmph, Speed: {GetSpeed}Kmph, Pace: {GetPace}min per Km";
    }
    
}