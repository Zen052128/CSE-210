using System;
public abstract class Activity
{
    protected DateTime _date;
    protected double _length;
    public Activity(DateTime date, double length)
    {
        _date = date;
        _length = length;
    }
    public abstract void GetSummary();
}