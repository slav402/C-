using System;

namespace Time_15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            if (minutes >= 10)
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
        }
    }
}
