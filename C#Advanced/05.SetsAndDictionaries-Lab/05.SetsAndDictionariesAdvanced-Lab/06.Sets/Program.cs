using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> lisName = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                lisName.Add(Console.ReadLine());
            }

            foreach (var name in lisName)
            {
                Console.WriteLine(name);
            }
        }
    }
}
