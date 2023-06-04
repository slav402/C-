using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core.Interfaces;
using WildFarm.Factotiess.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    internal class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private readonly IAnimalFactory animalFactory;
        private readonly IFoodFactory foodFactory;

        private readonly ICollection<IAnimal> animals;

        public Engine(
            IReader reader,
            IWriter writer,
            IAnimalFactory animalFactory,
            IFoodFactory foodFactory)
        {
            this.reader = reader;
            this.writer = writer;

            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;

            this.animals = new List<IAnimal>();
        }


        public void Run()
        {
            string command;
            while ((command = reader.ReadLine()) != "End")
            {
                IAnimal animal = null;

                try
                {
                    animal = CreateAnimal(command);

                    IFood food = CreateFood();

                    writer.WriteLine(animal.ProduceSound());

                    animal.Eat(food);

                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }


        private IAnimal CreateAnimal(string command)
        {
            string[] animalArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            IAnimal animal = animalFactory.CreateAnimal(animalArgs);

            return animal;
        }

        private IFood CreateFood()
        {
            string[] foodTokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string foodTyupe = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);

            IFood food = foodFactory.CreateFood(foodTyupe, foodQuantity);

            return food;
        }
    }
}
