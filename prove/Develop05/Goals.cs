using System;
public abstract class Goals
{

    private string _name {get; set;}
    private string _description {get; set;}
    
    private bool _IsCompleted {get; set;}

    private int _points  {get; set;}

    public Goals (string name, string description, bool IsCompleted, int points)

    {
        _name = name;
        _description = description;
        _IsCompleted = IsCompleted;
        _points = points;
        
    }

    public abstract int GetPoints();

    public abstract string GoalsToString();

}
   