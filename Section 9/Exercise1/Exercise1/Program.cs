using Exercise1.Entities;
using Exercise1.Entities.Enums;
using System.Globalization;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Department name:");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter Worker data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Level:(Junior  - MidLevel -  Senior )");     
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine());

            Department department = new Department(departmentName);
            Worker worker = new Worker(name,level,baseSalary,department);


            Console.Write("How many contracts to this worker:");

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write($"Date (DD/MM/YYYY):");
                string dateString = Console.ReadLine();
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration:");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date,valuePerHour,duration);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income(MM/YYYY):");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name :{worker.Name}" +
                              $"\nDepartment:{worker.Department.Name}" +
                              $"\nIncome for {monthAndYear}:{worker.Income(year,month)}");

        }
    }
}