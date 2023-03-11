public class ChecklistGoals : Goals
{
    // members
    private int _numTasks;
    private int _numberCompleted;
    private int _bonus;

    // Constructor
    public ChecklistGoals (string name, string description, bool IsCompleted, int points, int bonus, int numberCompleted, int numTasks)
     : base (name, description, IsCompleted, points )
    {
        _numTasks = numTasks;
        _numberCompleted = numberCompleted;
        _bonus = bonus;
    }

    // methods 
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override int GetPoints()
    {
        int points = IsCompleted ? 20 : 0;
        if (_numberCompleted ==  _numTasks)
        {
            points += 10;
        }
    return points;
    }

     public override string GoalsToString(){
        return $"CheckList Goal: Name: {name}, Description: {description}, Completed:  {IsCompleted}, Points: {points},  Bonus: {_bonus}, Status: {_numberCompleted}/{_numTasks}";
    }

    public void RecordEvent ()
    {
        if (!IsCompleted)
        {
            _numberCompleted++;
            if (_numberCompleted == _numTasks)
            {
                IsCompleted = true;
            }
        }
    }


}
