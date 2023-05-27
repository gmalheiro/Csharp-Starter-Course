using HashCollectionsForComparingEquality.Entities;

namespace HashCollectionsForComparingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet <string> set = new HashSet <string> (); 
            //set.Add("Alex");
            //set.Add("Maria");
            //Console.WriteLine(set.Contains("Maria"));
            // Se GetHasCode e Equal estiverem implementados a comparação vai ser possível
            // Dessa forma o processo é o seguinte -> Primeiro o getHashCode para comparar a igualdade e o Equals para confirmar

            //Se não estiverem implementados 
            // Tipos referência -> Compara  as referências dos ojetos o endereço de memória
            // Tipos valor, vai comparar os valores dos atributos-> Compara os valores dos objetos

            HashSet<Product> a = new HashSet<Product>();

            a.Add(new Product("TV",900.00)) ;
            a.Add(new Product("Notebook",1200.00)) ;
            
            HashSet<Point> b = new HashSet<Point>();

            b.Add(new Point(3, 4));
            b.Add(new Point(5,10));

            Product product = new Product("TV", 900.00);
            
            Console.WriteLine(a.Contains(product));

            Point p = new Point(5,10);
            Console.WriteLine(b.Contains(p));

        }
    }
}