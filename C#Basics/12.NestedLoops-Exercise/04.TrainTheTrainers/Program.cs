using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juriCount = int.Parse(Console.ReadLine());
            int counter = 0;
            double totalResult = 0;
            
            string insert = Console.ReadLine();

            while (insert != "Finish")
            {
                double assessment = 0;

                for (int i = 0; i < juriCount; i++)
                {
                    assessment += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"{insert} - {(assessment / juriCount):f2}");

                counter++;
                totalResult += (assessment / juriCount);

                insert = Console.ReadLine();
            }

            Console.WriteLine($"assessment is {(totalResult / counter):f2}");
        }
    }
}
