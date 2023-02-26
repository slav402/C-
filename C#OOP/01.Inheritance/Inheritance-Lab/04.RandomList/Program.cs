using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp    
    {
        static void Main(string[] args)
        {
            RandomList colection = new RandomList();

            colection.Add("1");
            colection.Add("2");
            colection.Add("3");
            colection.Add("4");
            colection.Add("5");
            colection.Add("6");

            Console.WriteLine(colection.RandomString());
        }
    }
}
