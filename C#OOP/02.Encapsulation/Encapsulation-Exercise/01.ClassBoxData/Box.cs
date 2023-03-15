using System;
using System.Collections.Generic;
using System.Text;

namespace BoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;


        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return lenght; }
            set 
            {
                ThrowIfInvalidSide(value, nameof(this.Length));
                lenght = value; 
            }
        }

        public double Width
        {
            get { return width; }
            set 
            {
                ThrowIfInvalidSide(value, nameof(this.Width));
                width = value; 
            }
        }

        public double Height
        {
            get { return height; }
            set 
            {
                ThrowIfInvalidSide(value, nameof(this.Length));
                height = value; 
            }
        }

        public double SurfaceArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        public double LateralSurfaceArea()
        {
            return 2 * (Length + Width) * Height;
        }

        public double CalculateVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        private void ThrowIfInvalidSide(double value, string sideName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{sideName} cannot be zero or negative.");
            }
        }
    }
}
