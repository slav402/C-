using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.IO.Interfaces;

namespace WildFarm.IO
{
    public class FileWriter : IWriter //za pisane vav file
    {
        public void WriteLine(string str)
        {
            using StreamWriter writer = new StreamWriter("..\\..\\..\\test.txt", true);
            writer.WriteLine(str);
        }
    }
}
