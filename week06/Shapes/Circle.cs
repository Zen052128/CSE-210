using System;
public class Circle : Shapes
{
    private double _radius;
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
}