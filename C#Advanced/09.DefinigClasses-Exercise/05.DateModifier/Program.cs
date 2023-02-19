using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            int days = DateModifier.GetDifBtwDatesInDays(dateOne, dateTwo);

            Console.WriteLine(days);
        }
    }
}
