using System;

namespace _06.SomeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle recOne = new Rectangle(2, 4, "red");
            Figure someFigure = new Figure(4, 6);

            recOne.PrintArea();
            Console.WriteLine(recOne.Color);

            Triangel triangel = new Triangel(4, 6);
            triangel.PrintArea();
        }

        public class Figure
        {
            public Figure(int width, int height)
            {
                this.Height = height;
                this.Width = width;
            }

            public int Width { get; set; }

            public int Height { get; set; }

            public virtual void PrintArea() => Console.WriteLine(Width * Height);
        }

        public class Rectangle : Figure
        {
            public Rectangle(int width, int height, string color)
                : base(width, height)
            {
                this.Color = color;
            }

            public string Color { get; set; }
        }

        public class Triangel : Figure
        {
            public Triangel(int width, int height) 
                : base(width, height)
            {
            }

            public override void PrintArea()
            {
                Console.WriteLine(Width * Height / 2.0);
            }
        }
    }
}
