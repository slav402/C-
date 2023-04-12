using System;
using System.Collections.Generic;
using System.Text;

namespace BorederControl.Models.Interfacess
{
    public class Robot
    {
        public Robot(string model, int id)
        {
            Model = model;
        }
        public string Model { get; private set; }
        public int Id { get; private set; }
    }
}
