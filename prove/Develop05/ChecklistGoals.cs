public class ChecklistGoals : Goals
{
    private int _numTasks;
    private int _numberCompleted;

    public ChecklistGoals (string name, string description, bool IsCompleted, int points, int numTasks, int numberCompleted) : base (name, description, IsCompleted, points )
    {
        _numTasks = numTasks;
        _numberCompleted = numberCompleted;
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

     public override string GoalsToString()
    {
        return "";
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
