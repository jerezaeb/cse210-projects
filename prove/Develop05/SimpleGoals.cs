public class SimpleGoals : Goals
{
    // constructor
    public SimpleGoals (string name, string description, bool IsCompleted, int points)
    : base(name, description, IsCompleted, points){}

    // methods 

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override int GetPoints()
    {
        if (IsCompleted) return points;
        else return 0;
    }
    public override string GoalsToString(){
        return $"Simple Goal: Name: {name}, Description: {description}, Completed: {IsCompleted}, Points: {points}";
    }
}
