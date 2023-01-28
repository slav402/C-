using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> result = new Dictionary<string, List<decimal>>(n);

            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string studetName = entry[0];
                decimal grade = decimal.Parse(entry[1]);

                if (!result.ContainsKey(studetName))
                {
                    result.Add(studetName, new List<decimal>());
                }

                result[studetName].Add(grade);
            }

            foreach (var student in result)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
