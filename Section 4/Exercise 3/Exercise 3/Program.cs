using Exercise_3.Entities;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangleX = new Triangle();
            Triangle triangleY = new Triangle();

            Console.WriteLine("Enter Triangle X measures:");
            triangleX.SideA = double.Parse(Console.ReadLine());
            triangleX.SideB = double.Parse(Console.ReadLine());
            triangleX.SideC = double.Parse(Console.ReadLine());
            
            double triangleXArea = triangleX.TriangleArea();

            Console.WriteLine("Enter Triangle Y measures:");
            triangleY.SideA = double.Parse(Console.ReadLine());
            triangleY.SideB = double.Parse(Console.ReadLine());
            triangleY.SideC = double.Parse(Console.ReadLine());

            double triangleYArea = triangleY.TriangleArea();

            Console.WriteLine(triangleXArea >= triangleYArea ? "Triangle X area is the largest" : "Triangle Y area is the largest");

        }
    }
}