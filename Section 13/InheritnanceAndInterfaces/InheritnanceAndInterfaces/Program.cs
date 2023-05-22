using InheritnanceAndInterfaces.Model.Entities;
using InheritnanceAndInterfaces.Model.Enums;
using System.Security.Cryptography.X509Certificates;

namespace InheritnanceAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(2.0,Color.White);
            IShape rectangle = new Rectangle(3.5,4.2,Color.Black);
            Console.WriteLine(circle);
            Console.WriteLine(rectangle);
        }
    }
}