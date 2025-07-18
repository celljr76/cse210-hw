using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5, "purple");
        Rectangle rectangle = new Rectangle(10, 5, "green");
        Circle circle = new Circle(3, "yellow");
        List<Shape> shapes = new List<Shape>();

        //Console.WriteLine($"Area of your square is {square.GetArea()}, the color of your square is {square.GetColor()}");
        //Console.WriteLine($"Area of your rectangle is {rectangle.GetArea()}, the color of your rectangle is {rectangle.GetColor()}");
        //Console.WriteLine($"The area of your circle is {circle.GetArea()}, the color of your circle is {circle.GetColor()}");
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }



    }
}