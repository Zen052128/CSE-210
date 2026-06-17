using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square();
        square1.SetColor("red");
        square1.SetSides(18);

        Rectangle rectangle1 = new Rectangle();
        rectangle1.SetColor("green");
        rectangle1.SetParameters(21, 18);

        Circle circle1 = new Circle();
        circle1.SetColor("blue");
        circle1.SetRadius(2005);

        List<Shapes> allShapes = new List<Shapes>();
        allShapes.Add(square1);
        allShapes.Add(rectangle1);
        allShapes.Add(circle1);

        foreach (Shapes shapes in allShapes)
        {
            shapes.GetColor();
            double area = shapes.GetArea();
            Console.WriteLine(area);
            Console.WriteLine();
        }
    }
}