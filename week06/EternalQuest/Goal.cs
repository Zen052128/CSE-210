using System;
using System.Runtime.CompilerServices;
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    public double _points;
    public Goal(string name, string description, double points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetShortName()
    {
        return _shortName;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailString();
    public abstract string GetStringRepresentation();
}