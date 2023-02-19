using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] enter = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = enter[0];
                int age = int.Parse(enter[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Person[] oldDudes = family.GerOverThirty();

            foreach (var guy in oldDudes)
            {
                Console.WriteLine($"{guy.Name} - {guy.Age}");
            }
        }
    }
}
