using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape = new Square("Red", 3);
        shapes.Add(shape);

        Rectangle shape1 = new Rectangle("Yellow", 4, 5);
        shapes.Add(shape1);

        Circle shape2 = new Circle("Blue", 6);
        shapes.Add(shape2);

        foreach (Shape i in shapes)
        {
            
            string color = i.GetColor();
            double area = i.GetArea();
            Console.WriteLine($"The {color} {shape} has an area of {area}.");
        }
    }
}