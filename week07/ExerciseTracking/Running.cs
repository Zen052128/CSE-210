using System;
public class Running : Activity
{
    private double _distance;
    public Running(string date, double length, double distance) : base (date, length)
    {
        _distance = distance;
    }
    public override void GetSummary()
    {
        double speed = _distance / (_length / 60);
        double pace = _length / _distance;
        
        Console.WriteLine($"{_date} Running ({_length} min) - Distance {_distance} kilometers, Speed {speed} kph, Pace {pace} min per km");
    }
}