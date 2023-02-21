using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine )
        {
            Model = model;
            Engine = engine;
            Weight = null;
            Color = "n/a";
        }

        public Car(string model, Engine engine, int weight, string color) 
            :this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string str = $"{this.Model}:" + Environment.NewLine;
            str += $"  {Engine.Model}:" + Environment.NewLine;
            str += $"    Power: {Engine.Power}" + Environment.NewLine;

            if (Engine.Displacement == null)
            {
                str += "    Displacement: n/a" + Environment.NewLine;
            }
            else
            {
                str += $"    Displacement: {Engine.Displacement}" + Environment.NewLine;
            }

            str += $"    Efficiency: {Engine.Efficiency}" + Environment.NewLine;

            if (this.Weight == null)
            {
                str += "  Weight: n/a" + Environment.NewLine;
            }
            else
            {
                str += $"  Weight: {this.Weight}" + Environment.NewLine;
            }

            str += $"  Color: {this.Color}";


            return str;
        }
    }
}
