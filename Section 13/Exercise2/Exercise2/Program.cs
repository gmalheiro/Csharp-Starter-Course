using Exercise2.Entities;
using Exercise2.Services;
using System.Globalization;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine()!);
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract value:");
                double value = double.Parse(Console.ReadLine()!);
                Console.Write("Enter number of installments:");
                int numberOfInstallments = int.Parse(Console.ReadLine()!);

                Contracts contract = new Contracts(number, date, value);
                ContractService contractService = new ContractService(new PaypalService());
                contractService.ProcessContract(contract, numberOfInstallments);

                Console.WriteLine("Installments:");
                contract.Installment.ForEach(
                    installment =>
                    {
                        Console.WriteLine(installment.ToString());
                    });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message)   ;
            }
            finally
            {
                Console.WriteLine("Contract processed!");
            }
        }
    }
}