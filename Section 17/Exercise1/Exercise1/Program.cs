using Exercise1.Entities;
using System.Transactions;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path:");
            string? path = Console.ReadLine();
            List<Product> products = new List<Product>();   
            try
            {
                using (StreamReader sr = File.OpenText(path!))
                {
                    while (!sr.EndOfStream)
                    {
                        string? line = sr.ReadLine();
                        string[] product = line?.Split(",")!;
                        string productName = product[0];
                        double productPrice = double.Parse(product[1]);
                        products.Add(new Product(productName, productPrice));   
                    }
                }

                var productsAveragePrice = products.Average(product => product.Price);
                Console.WriteLine($"Average price: {productsAveragePrice.ToString("F2")}");

                var productsBelowPriceAverage = products
                                                .Where(product => product.Price < productsAveragePrice)
                                                .OrderByDescending(product => product.Name)
                                                .Select(product => product.Name)
                                                .ToList();

                productsBelowPriceAverage.ForEach(product => Console.WriteLine(product));

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);

            }

        }
    }
}