using System;
using System.Diagnostics.Contracts;
public class Square : Shapes
{
    private double _sides;
    public void SetSides(double sides)
    {
        _sides = sides;
    }
    public override double GetArea()
    {
        return _sides * _sides;
    }
}