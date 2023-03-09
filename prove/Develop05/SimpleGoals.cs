public class SimpleGoals : Goals
{
    public SimpleGoals (string name, string description)
    {
        _name = name;
        _description = description;
    }

    public override int GetPoints()
    {
        return IsCompleted ? 10 :0;
    }
}
