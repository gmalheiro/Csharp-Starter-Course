using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaWhile.Exercises
{
    public class Cartesian
    {
        public static void CartesianCoordinates()
        {
            double x, y;

            Console.Write("Type the X coordinate:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Type the Y coordinate:");
            y = double.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine($"First quadrant");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"Third Quadrant");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine($"Fourth Quadrant");
                }
                Console.ReadLine();
                Console.Clear();
                Console.Write("Type the X coordinate:");
                x = double.Parse(Console.ReadLine());
                Console.Write("Type the Y coordinate:");
                y = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine($"Second quadrant");

        }
    }
}
