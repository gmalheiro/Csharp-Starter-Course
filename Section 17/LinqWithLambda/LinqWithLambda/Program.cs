using LinqWithLambda.Entities;
using System.IO.Pipes;

namespace LinqWithLambda
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj); ;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Electronics", 1);


            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };



            var r1 = products.Where(x => x.Price < 900 && x.Category?.Tier == 1);
            Print("TIER 1 AND PRICE < 900", r1);

            var r2 = products.Where(product => product.Category?.Name == "Tools").Select(product => product.Name);
            Print("NAME OF PRODUCTS FROM TOOLS CATEGORY", r2);

            var r3 = products.Where(product => product.Name!.StartsWith("C")).Select(product => new { product.Name, product.Price, CategoryName = product.Category?.Name });
            Print("PRODUCTS WITH INITIAL LETTER C AND ANONYMOUS OBJ", r3);

            var r4 = products.Where(product => product.Category?.Tier == 1).OrderBy(product => product.Price).ThenBy(product => product.Name); // Primeiro ordena pelo preço e depois pelo nome
            //var r4 = products.Where(product => product.Category?.Tier == 1).OrderByDescending(product => product.Price)  ORDENAR DE FORMA DECRESCENTE;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT TEST 1: " + r6);

            var r7 = products.Where(product => product.Price > 3000).FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT TESTE 2: " + r7);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default TEST 1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default TEST 2: " + r9);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min Price: " + r11);

            var r12 = products.Where(product => product.Category?.Id == 1).Sum(product => product.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            var r13 = products.Where(product => product.Category?.Id == 1).Average(product => product.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            var r14 = products.Where(product => product.Category?.Id == 5).Select(product => product.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            var r15 = products.Where(product => product.Category?.Id == 1).Select(product => product.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate Sum prices: " + r15);

            //var r16 = products.Where(product => product.Category?.Id == 5).Select(product => product.Price).Aggregate(0.0, (x, y) => x + y);
            //Console.WriteLine("Category 5 Aggregate Sum prices with null treatment: " + r16);

            var r16 = products.GroupBy(p => p.Category);

            foreach (IGrouping<Category?, Product> group in r16)
            {
                Console.WriteLine("Category " + group?.Key?.Name + ":");
                foreach (Product product in group!)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }
    }
}