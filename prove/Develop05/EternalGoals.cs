public class EternalGoals : Goals
{
public EternalGoals (string name, string description)
    {
        _name = name;
        _description = description;
    }

    public override int GetPoints()
    {
        return IsCompleted? 5:0;
    }
}


