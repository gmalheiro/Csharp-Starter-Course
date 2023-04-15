using Exercise3.Entities;
using Exercise3.Entities.Enums;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Shape> shapes = new List <Shape> ();

            Console.Write("Enter the number of shapes:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++ )
            {
                Console.WriteLine($"Shape {i} data:");
                Console.Write("Rectangle or Circle (r/c)?");
                string shape = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (shape == "r")
                {
                    Console.Write("Width:");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height:");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius:");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine("SHAPE AREAS:");

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}