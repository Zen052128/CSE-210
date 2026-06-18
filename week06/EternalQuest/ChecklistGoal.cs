using System;
using System.Runtime;
public class ChecklistGoal : Goal
{
    private double _amountCompleted;
    private double _target;
    private double _bonus;
    public ChecklistGoal(string name, string description, double points, double target, double amountCompleted, double bonus) : base (name, description, points)
    {
        _target = target;
        _amountCompleted = amountCompleted;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;

        if(_amountCompleted >= 2)
        {
            _points = _bonus;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return true;
        }
    }
    public override string GetDetailString()
    {
        if (!IsComplete())
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[✔] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}|{IsComplete()}";
    }
}