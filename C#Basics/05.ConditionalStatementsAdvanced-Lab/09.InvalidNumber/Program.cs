using System;

namespace _09.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            //if (number < 100 || number > 200)
            //{
            //    if (number == 0)
            //    {
            //        console.writeline();
            //    }
            //    else
            //    {
            //        console.writeline("invalid");
            //    }
            //}

            if (number == 0 || (number >= 100 && number <= 200))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
