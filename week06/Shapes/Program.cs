using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.\n");
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("blue square", 12);
        shapes.Add(square1);
        Rectangle rect1 = new Rectangle("red rectangle", 5, 15);
        shapes.Add(rect1);
        Circle circle1 = new Circle("yellow circle", 5);
        shapes.Add(circle1);
        Circle circle2 = new Circle("green circle", 11);
        shapes.Add(circle2);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetColor()} is {shape.GetArea()} sq mm");
        }
    }
}