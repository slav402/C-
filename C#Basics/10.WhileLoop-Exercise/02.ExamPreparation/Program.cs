using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int errorLimit = int.Parse(Console.ReadLine());

            double sumOfAssessment = 0;
            int errorCounter = 0;
            int solvedProblems = 0;
            string lastProblem = string.Empty;

            string problemName = Console.ReadLine();

            while (problemName != "Enough")
            {
                double currentAssessment = double.Parse(Console.ReadLine());

                if (currentAssessment <= 4)
                {
                    errorCounter++;
                }

                if (errorCounter == errorLimit)
                {
                    Console.WriteLine($"You need a break, {errorCounter} poor grades.");
                    return;
                }

                sumOfAssessment += currentAssessment;
                solvedProblems++;
                lastProblem = problemName;

                problemName = Console.ReadLine();
            }


            Console.WriteLine($"Average score: {(sumOfAssessment/(double)solvedProblems):f2}");
            Console.WriteLine($"Number of problems: {solvedProblems}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}
