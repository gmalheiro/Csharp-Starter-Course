using Exercise4.Entities;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Enter product data");
            Console.Write("Name:");
            product.Name = Console.ReadLine();
            Console.Write("Price:");
            product.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantity:");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine(product.ToString());



        }
    }
}