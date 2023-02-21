using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engineList = new List<Engine>();
            List<Car> carList = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputEngineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputEngineData[0];
                int power = int.Parse(inputEngineData[1]);

                Engine currentEngine = new Engine(model, power);

                if (inputEngineData.Length > 2)
                {
                    EnteringEngineData(inputEngineData, currentEngine);
                }

                engineList.Add(currentEngine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] inputCarData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputCarData[0];
                string engineModel = inputCarData[1];

                Engine engine = engineList.FirstOrDefault(e => e.Model == engineModel);

                Car currentCar = new Car(model, engine);

                if (inputCarData.Length > 2)
                {
                    EnteringCarData(inputCarData, currentCar);
                }

                carList.Add(currentCar);
            }

            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static void EnteringCarData(string[] inputCarData, Car currentCar)
        {
            if (inputCarData.Length == 3)
            {
                int weight;
                bool isInt = int.TryParse(inputCarData[2], out weight);

                if (isInt)
                {
                    currentCar.Weight = weight;
                }
                else
                {
                    currentCar.Color = inputCarData[2];
                }
            }
            else
            {
                currentCar.Weight = int.Parse(inputCarData[2]);
                currentCar.Color = inputCarData[3];
            }
        }

        private static void EnteringEngineData(string[] inputEngineData, Engine currentEngine)
        {
            if (inputEngineData.Length == 3)
            {
                int displacement;
                bool isInt = int.TryParse(inputEngineData[2], out displacement);

                if (isInt)
                {
                    currentEngine.Displacement = displacement;
                }
                else
                {
                    currentEngine.Efficiency = inputEngineData[2];
                }
            }
            else
            {
                currentEngine.Displacement = int.Parse(inputEngineData[2]);
                currentEngine.Efficiency = inputEngineData[3];
            }
        }
    }
}
