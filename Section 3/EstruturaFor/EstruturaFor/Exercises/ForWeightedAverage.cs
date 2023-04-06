using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaFor.Exercises
{
    public class ForWeightedAverage
    {
        public static void WeightedAverage()
        {
            Console.Write("Type the number of test cases: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Type value 1: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Type value 2: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Type value 3: ");
                double c = double.Parse(Console.ReadLine());

                double weightedAverage = (a * 2 + b * 3 + c * 5) / 10;

                Console.WriteLine($"Weighted Average: {weightedAverage:F1}");
            }
        }
    }
}
