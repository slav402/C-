﻿using System;

namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);

            circle.Draw();
            rectangle.Draw();
        }
    }
}
