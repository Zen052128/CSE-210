using System;
public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double length, double speed) : base (date, length)
    {
        _speed = speed;
    }
    public override void GetSummary()
    {
        double distance = _speed * (_length / 60);
        double pace = _length / distance;
        
        Console.WriteLine($"{_date} Cycling ({_length} min) - Distance {distance} kilometers, Speed {_speed} kph, Pace {pace} min per km");
    }
}