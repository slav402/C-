using System;
using System.Linq;
using System.Collections.Generic;


namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = range[0];
            int m = range[1];

            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                setN.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                setM.Add(int.Parse(Console.ReadLine()));
            }

            //setN.UnionWith(setM);
            //setn.exceptwith(setm);
            //setN.SymmetricExceptWith(setM);

            setN.IntersectWith(setM);

            Console.WriteLine(String.Join(" ", setN));
        }
    }
}
