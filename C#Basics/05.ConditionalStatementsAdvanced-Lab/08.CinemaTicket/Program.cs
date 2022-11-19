using System;

namespace _08.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            switch (day.ToLower())
            {
                case "monday":
                case "tuesday":
                case "friday":
                    Console.WriteLine(12);
                    break;

                case "wednesday":
                case "thursday":
                    Console.WriteLine(14);
                    break;

                default:
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}
