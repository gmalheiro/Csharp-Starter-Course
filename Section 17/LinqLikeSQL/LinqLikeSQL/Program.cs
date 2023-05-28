using LinqLikeSQL.Entities;
using System.IO.Pipes;

namespace LinqLikeSQL
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



            //var r1 = products.Where(x => x.Price < 900 && x.Category?.Tier == 1);
            var r1 =   
                from p in products
                where p.Category?.Tier == 1 && p.Price < 900
                select p;
            Print("TIER 1 AND PRICE < 900", r1);

            //var r2 = products.Where(product => product.Category?.Name == "Tools").Select(product => product.Name);
            var r2 = from p in products
                     where p.Category?.Name == "Tools"
                     select p.Name;
            Print("NAME OF PRODUCTS FROM TOOLS CATEGORY", r2);

            //var r3 = products.Where(product => product.Name!.StartsWith("C")).Select(product => new { product.Name, product.Price, CategoryName = product.Category?.Name });
            var r3 = from p in products
                     where p.Name![0] == 'C'
                     select new { p.Name, p.Price, CategoryName = p.Category?.Name };
            Print("PRODUCTS WITH INITIAL LETTER C AND ANONYMOUS OBJ", r3);

            //var r4 = products.Where(product => product.Category?.Tier == 1).OrderBy(product => product.Price).ThenBy(product => product.Name); // Primeiro ordena pelo preço e depois pelo nome
            //var r4 = products.Where(product => product.Category?.Tier == 1).OrderByDescending(product => product.Price)  ORDENAR DE FORMA DECRESCENTE;
            var r4 = from p in products
                     where p.Category?.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4
                      select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            //var r6 = products.FirstOrDefault();
            var r6 = (from p in products select p).FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT TEST 1: " + r6);

            //var r7 = products.Where(product => product.Price > 3000).FirstOrDefault();
            var r7 = (from p in products
                      where p.Price > 3000
                      select p).FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT TESTE 2: " + r7);

            //var r16 = products.GroupBy(p => p.Category);
            var r16 = (from p in products
                       group p by p.Category);

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