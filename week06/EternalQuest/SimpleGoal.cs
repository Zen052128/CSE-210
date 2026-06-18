using System;
public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, double points) : base (name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailString()
    {
        if (!IsComplete())
        {
            return $"[ ] {_shortName} ({_description})";
        }
        else 
        {
            return $"[✔] {_shortName} ({_description})";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"Simple Goal|{_shortName}|{_description}|{_points}|{IsComplete()}";
    }
}