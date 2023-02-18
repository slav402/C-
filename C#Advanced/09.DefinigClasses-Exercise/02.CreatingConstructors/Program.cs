using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person oneDude = new Person();

            Person someGuy = new Person(22);

            Person otherDude = new Person("Kuku", 34);

            Console.WriteLine($"{oneDude.Name}, {oneDude.Age}");
            Console.WriteLine($"{someGuy.Name}, {someGuy.Age}");
            Console.WriteLine($"{otherDude.Name}, {otherDude.Age}");
        }
    }
}
