using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string surchedBook = Console.ReadLine();
            int counter = 0;

            string input = Console.ReadLine();

            while (input != surchedBook)
            {

                if (input == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!\nYou checked {counter} books.");
                    return;
                }

                counter++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"You checked {counter} books and found it.");
        }
    }
}
