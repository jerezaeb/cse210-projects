public class EternalGoals : Goals
{
    //Constructor
    public EternalGoals (string name, string description, bool IsCompleted, int points)
    :base(name, description, IsCompleted, points){}

    // methods
    public override bool IsComplete()
    {
        return false;
    }
    public override int GetPoints()
    {
        return points;
    }
    public override string GoalsToString(){
       return $"Eternal Goal: Name: {name}, Description: {description},  Completed: {IsCompleted}, Points: {points}";
    }
}
