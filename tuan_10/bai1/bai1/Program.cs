using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(2, "red", true);
            Console.WriteLine(square.getSide());
            Console.WriteLine(square.getColor());
            Console.WriteLine(square.isFilled());
            Console.WriteLine(square.toString());
            Rectangle rectangle = new Rectangle(3,4,"blue",false);
            Console.WriteLine(rectangle.getLength());
            Console.WriteLine(rectangle.getWidth());
            Console.WriteLine(rectangle.getColor());
            Console.WriteLine(rectangle.isFilled());
            Console.WriteLine(rectangle.getArea());
            Console.WriteLine(rectangle.getPerimeter());
            Console.WriteLine(rectangle.toString());
            Circle circle = new Circle(3, "white", true);
            Console.WriteLine(circle.getRadius());
            Console.WriteLine(circle.getArea());
            Console.WriteLine(circle.getPerimeter());
            Console.WriteLine(circle.toString());

        }
    }
}

