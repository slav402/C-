using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int classCounter = 0;
            double sumGrade = 0;
            int foulCounter = 0;

            while (classCounter != 12)
            {
                double assessment = double.Parse(Console.ReadLine());

                if (assessment < 4)
                {
                    foulCounter++;
                }

                if (foulCounter == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {classCounter} grade");
                    return;
                }

                sumGrade += assessment;
                classCounter++;
            }

            Console.WriteLine($"{name} graduated. Average grade: {(sumGrade/classCounter):f2}");
        }
    }
}
