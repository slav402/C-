using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }    //TODO add validation
        }

        public double Height
        {
            get { return this.height; }
            private set { this.height = value; }    //TODO add validation
        }


        public override double CalculateArea()
            => this.Width * this.Height;

        public override double CalculatePerimeter()
            => (this.Width + this.Height) * 2;


    }
}
