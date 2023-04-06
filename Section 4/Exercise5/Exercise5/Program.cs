namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the dollar price:");
            double DollarPrice = double.Parse(Console.ReadLine());
            Console.Write("How many dollars will be bought:");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Amount to be paid in reais = " + CurrencyCalculator.DollarCurrencyCalculator(DollarPrice, amount).ToString("F2"));
        }
    }
}