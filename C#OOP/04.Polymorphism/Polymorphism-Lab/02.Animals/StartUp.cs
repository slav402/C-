using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            List<Animal> listOfAnimals = new List<Animal>
            {
                new Dog("George", "Meat"),
                new Cat("Peter", "Whiskas")
            };
            
            foreach (Animal animal in listOfAnimals)
            {
                Console.WriteLine(animal.ExplainSelf());
            }
        }

    }
}