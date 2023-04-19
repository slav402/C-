using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            Shape rectangle = new Rectangle(10, 15);
            Shape circle = new Circle(5);

            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
        }

    }
}