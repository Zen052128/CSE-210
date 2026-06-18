using System;
public class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, double length, double laps) : base (date, length)
    {
        _laps = laps;
    }
    public override void GetSummary()
    {
        double distance = (_laps * 50) / 1000;
        double speed = distance / (_length / 60);
        double pace = _length / distance;
        
        Console.WriteLine($"{_date} Swimming ({_length} min) - Distance {distance} kilometers, Speed {speed} kph, Pace {pace} min per km");
    }
}