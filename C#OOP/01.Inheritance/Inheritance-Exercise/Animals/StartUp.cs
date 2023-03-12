using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstLineInput;

            while ((firstLineInput = Console.ReadLine()) != "Beast!")
            {
                string[] secondLineInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = secondLineInput[0];
                int age = int.Parse(secondLineInput[1]);
                string gender = secondLineInput[2];

                if (string.IsNullOrEmpty(name) || age < 0 || string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    if (firstLineInput == "Cat")
                    {
                        var animal = new Cat(name, age, gender);

                        Console.WriteLine(animal);
                    }
                    else if (firstLineInput == "Dog")
                    {
                        var animal = new Dog(name, age, gender);

                        Console.WriteLine(animal);
                    }
                    else if (firstLineInput == "Frog")
                    {
                        var animal = new Frog(name, age, gender);

                        Console.WriteLine(animal);
                    }
                    else if (firstLineInput == "Tomcat")
                    {
                        var animal = new Tomcat(name, age);

                        Console.WriteLine(animal);
                    }
                    else if (firstLineInput == "Kittens")
                    {
                        var animal = new Kitten(name, age);

                        Console.WriteLine(animal);
                    }
                }
            }
        }
    }
}
