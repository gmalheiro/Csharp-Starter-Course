using UsingComparison.Entities;

namespace UsingComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV",900.00));
            products.Add(new Product("Notebook",1200.00));
            products.Add(new Product("Tablet",450.00));

            Comparison<Product> comp =  (Product p1, Product p2) => (p1.Name?.ToUpper() ?? "").CompareTo(p2.Name?.ToUpper()?? "") ;

            products.Sort((Product p1, Product p2) => (p1.Name?.ToUpper() ?? "").CompareTo(p2.Name?.ToUpper() ?? ""));

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

        }

        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return (p1?.Name?.ToUpper() ?? "").CompareTo(p2?.Name?.ToUpper() ?? "");
        //}
    }
}