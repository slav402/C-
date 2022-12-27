using System;

namespace _01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine();

            while (entry != "Stop")
            {
                Console.WriteLine(entry);

                entry = Console.ReadLine();
            }
        }
    }
}
