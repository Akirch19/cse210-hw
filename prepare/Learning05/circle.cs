using System;

public class Circle : Shape
{
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return Math.Round(PI * (_radius * _radius), 2);
    }

    public override string GetShapeType()
    {
        return _type;
    }
    private double _radius = 0;
    private const double PI = 3.1415926535897931;
    private string _type = "Circle";

}