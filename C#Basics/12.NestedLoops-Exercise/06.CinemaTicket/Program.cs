using System;

namespace _06.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double student = 0;
            double standard = 0;
            double kid = 0;
            double tottalTickests = 0;

            while (movie != "Finish")
            {
                double room = double.Parse(Console.ReadLine());
                double selledTicket = 0;

                for (int i = 0; i < room; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    switch (ticketType)
                    {
                        case "student": 
                            student++; 
                            break;

                        case "standard": 
                            standard++; 
                            break;

                        case "kid": 
                            kid++; 
                            break;
                    }

                    tottalTickests++;
                    selledTicket++;
                }

                Console.WriteLine($"{movie} - {(selledTicket / room * 100):f2}% full.");

                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {tottalTickests}");
            Console.WriteLine($"{(student / tottalTickests * 100):f2}% student tickets.");
            Console.WriteLine($"{(standard / tottalTickests * 100):f2}% standard tickets.");
            Console.WriteLine($"{(kid / tottalTickests * 100):f2}% kid tickets.");
        }
    }
}
