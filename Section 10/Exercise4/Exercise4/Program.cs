using Exercise4.Entities;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers:");
            int taxPayers = int.Parse(Console.ReadLine());
            List<TaxPayer> taxPayerList = new List<TaxPayer>();
            for (int i = 1; i <= taxPayers;  i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company?");
                string individualOrCompany = Console.ReadLine();
                if (individualOrCompany == "i")
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income:");
                    double annualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures:");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayerList.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income:");
                    double annualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees:");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayerList.Add(new Company(name, annualIncome,numberOfEmployees));
                }
            }

            double totalTaxes = 0;
            foreach (var taxPayer in taxPayerList)
            {
                Console.WriteLine($"TAXES PAID:" +
                                  $"{taxPayer.Name}: ${taxPayer.Tax().ToString("F2")}");
                totalTaxes += taxPayer.Tax();
            }

            Console.WriteLine($"Total Taxes : ${totalTaxes.ToString("F2")}");

        }
    }
}