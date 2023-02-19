using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(double pressure, int year)
        {
            Pressure = pressure;
            Year = year;
        }

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

    }
}
