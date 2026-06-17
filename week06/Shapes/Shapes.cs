using System;

public abstract class Shapes
{
    private string _color;
    public void GetColor()
    {
        Console.WriteLine(_color);
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}