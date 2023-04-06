using Exercise1.Entities;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonBankAccount account = new PersonBankAccount();

            Console.Write("Type account number:");
            account.AccountNumber = int.Parse(Console.ReadLine());

            Console.Write("Type owner name:");
            account.Name = Console.ReadLine();

            Console.Write("Will you deposit something:(Y/N)");
            string choice = Console.ReadLine(); 
            if (choice.ToUpper() == "Y" )
            {
                Console.Write("Type the amount:");
                account.Balance = double.Parse(Console.ReadLine());
            } 

            Console.Clear();
            Console.WriteLine(account.ToString());

            Console.Write("Type a value to deposit:");
            double deposit = double.Parse(Console.ReadLine());
            account.Balance += deposit;


            Console.Clear() ;

            Console.Write("Wanna draw some money:(Y/N)");
            choice = Console.ReadLine();
            if (choice.ToUpper() == "Y")
            {
                Console.Write("Type the amount:");
                double amount = double.Parse(Console.ReadLine());
                account.Balance -= (amount + 5.00);
            }

            Console.Clear();

            Console.WriteLine("Account data updated");
            Console.WriteLine(account.ToString());

        }
    }
}