using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            List<Person> personsList = new List<Person>();

            for (int i = 0; i < inputLines; i++)
            {
                var entry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person curentPerson = new Person(entry[0], entry[1], int.Parse(entry[2]));

                personsList.Add(curentPerson);
            }

            personsList.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
