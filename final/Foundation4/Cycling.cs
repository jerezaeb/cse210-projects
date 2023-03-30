public class Cycling: Exercise
{
    private float _speed;


    public Cycling (DateOnly date, int duration, float speed): base (date, duration)
    {
        _speed = speed;
    }

    public override float GetDistance ()
    {
        return _speed * (duration / 60);
    }
     public override float GetSpeed ()
    {
        return _speed;
    }

}