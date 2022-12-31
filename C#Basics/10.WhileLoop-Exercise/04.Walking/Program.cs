using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int targetSteps = 10000;

            while (steps < targetSteps)
            {
                string enter = Console.ReadLine();

                if (enter == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;
                }

                steps += int.Parse(enter);
            }

            if (steps >= targetSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - targetSteps} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{targetSteps - steps} more steps to reach goal.");
            }
        }
    }
}
