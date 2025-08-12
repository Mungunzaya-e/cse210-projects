using System;

public class Rectangle : Shape
{
    private double _side;
    private double _side2;

    public Rectangle(string color, double side, double side2) : base(color)
    {
        _color = color;
        _side = side;
        _side2 = side2;
    }

    public override double GetArea()
    {
        return _side * _side2;
    }
}