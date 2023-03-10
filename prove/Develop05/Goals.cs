using System;
public abstract class Goals
{
    // members
    private string _name;
    private string _description;
    private bool _IsCompleted;
    private int _points;
    
    // getters & setters
    public string name {get => _name; set => _name=value;}
    public string description {get => _description; set => _description=value;}
    public bool IsCompleted {get => _IsCompleted; set => _IsCompleted=value;}
    public int points {get => _points; set => _points=value;}
    
    // constructor
    public Goals (string name, string description, bool IsCompleted, int points)

    {
        _name = name;
        _description = description;
        _IsCompleted = IsCompleted;
        _points = points;
        
    }
    
    // methods 
    public abstract bool IsComplete();
    public abstract int GetPoints();
    public abstract string GoalsToString();

}
   