using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double singleNughtPrice = 0.0;
            double discount = 0.0;
            double bill = 0.0;

            if (roomType == "room for one person")
            {
                singleNughtPrice = 18.0;
            }
            else if (roomType == "apartment")
            {
                singleNughtPrice = 25.0;

                if (days < 10)
                {
                    discount = 0.3;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.35;
                }
                else
                {
                    discount = 0.5;
                }
            }
            else
            {
                singleNughtPrice = 35.0;

                if (days < 10)
                {
                    discount = 0.1;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.15;
                }
                else
                {
                    discount = 0.2;
                }
            }

            bill = (days - 1) * singleNughtPrice * (1 - discount);

            if (rating == "negative")
            {
                bill *= .9;
            }
            else
            {
                bill *= 1.25;
            }

            Console.WriteLine($"{bill:f2}");
        }
    }
}
