﻿using System;

namespace _02._Pounds_to_Dollars
{
    class PoundsToDollars
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * 1.31M;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}
