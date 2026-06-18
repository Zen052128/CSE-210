using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, double points) : base (name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailString()
    {
        if (!IsComplete())
        {
            return $"[ ] {_shortName} ({_description})";
        }
        else
        {
            return $"This is eternal, it cannot stop!!!";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal|{_shortName}|{_description}|{_points}|{IsComplete()}";
    }
}