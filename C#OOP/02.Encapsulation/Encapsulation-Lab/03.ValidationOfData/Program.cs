using System;
using System.Collections.Generic;

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
                try
                {
                    var entry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    Person curentPerson = new Person(entry[0], entry[1], int.Parse(entry[2]), decimal.Parse(entry[3]));

                    personsList.Add(curentPerson);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                
            }

            var increasePercent = decimal.Parse(Console.ReadLine());

            personsList.ForEach(p => p.IncreaseSalary(increasePercent));
            personsList.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
