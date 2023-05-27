namespace LinqIntroduction
{
    internal class Program
    {
        // Para trabalhar com LINQ é necessário
        // Criar um data source
        // Definir uma query
        // Executar a query  
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query
            //var result = numbers.Select(x => x % 2 == 0 ? x * 10 : x ).ToArray();
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Execute the query
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}