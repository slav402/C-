using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int turns = int.Parse(Console.ReadLine());

            for (int i = 0; i < turns; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (var name in names)
            {
                Console.WriteLine(na);
            }
        }
    }
}
