using Exercise_2.Entities;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                string typeOfProduct = Console.ReadLine();
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine());
                double customFee = 0.0;
                DateTime manufactureDate; 
                if (typeOfProduct == "i")
                {
                    Console.Write("Customs fee:");
                    customFee = double.Parse(Console.ReadLine());
                    ImportedProducts importedProducts = new ImportedProducts(name,price,customFee);
                    products.Add(importedProducts);
                }
                else if (typeOfProduct == "u")
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY):");
                    manufactureDate = DateTime.Parse(Console.ReadLine());
                    UsedProducts usedProduct = new UsedProducts(name,price,manufactureDate);
                    products.Add(usedProduct);
                }
                else
                {
                    Products product = new Products(name,price);
                    products.Add(product);
                }
            }

            Console.WriteLine("Price Tags:");
            foreach (var product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
            //Colocar o subString no date?
        }
    }
}