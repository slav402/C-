using System;
using System.Collections.Generic;
using System.Text;

namespace BoxData
{
    public class Box
    {
        private double length;
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
            get => length;
            private set
            {
                ThrowIfInvalidSide(value, nameof(this.Length));
                length = value; 
            }
        }

        public double Width 
        {
            get => width;
            private set
            {
                ThrowIfInvalidSide(value, nameof(this.Width));
                width = value; 
            }
        }

        public double Height    
        {
            get => height;
            private set
            {
                ThrowIfInvalidSide(value, nameof(this.Height));
                height = value; 
            }
        }

        public double SurfaceArea()
        {
            return 2 * (Length * Height + Height * Width + Length * Width); 
        }

        public double LateralSurfaceArea()
        {
            return 2 * Height * (Length + Width);
        }

        public double CalculateVolume()
        {
            return Length * Width * Height;
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
