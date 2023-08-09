using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeClass3;

namespace Reflection
{
    public class Laptop : Product
    {
        public int Cores { get; set; }

        public void Start()
        {
            Console.WriteLine("Laptop is starting");
        }
    }
}
