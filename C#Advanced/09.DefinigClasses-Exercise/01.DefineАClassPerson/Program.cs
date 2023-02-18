using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person someGuy = new Person();

            someGuy.Name = "Pipi";
            someGuy.Age = 34;

            Person otherDude = new Person("Koko", 23);
        }
    }
}
