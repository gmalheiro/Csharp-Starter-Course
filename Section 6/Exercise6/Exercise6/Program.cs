using Exercise6.Utilities;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List <Employees> employees = new List <Employees>();

            Console.Write("How many employees will be registered:");
            int employeesToBeRegistered = int.Parse(Console.ReadLine());

            for(int i = 1; i <= employeesToBeRegistered; i++)
            {
                Console.WriteLine($"Employee{i}");
                Console.Write($"Id:");
                int Id = int.Parse(Console.ReadLine());
                Console.Write($"Name:");
                string Name = Console.ReadLine();
                Console.Write($"Sallary:");
                double Sallary = double.Parse(Console.ReadLine());
                employees.Add(new Employees(Id,Name,Sallary));
            }

            Console.Write("Enter the employee ID to that will have sallary increase:");
            int employeeIdToReceiveIncrease = int.Parse(Console.ReadLine());

            Console.Write("Enter the percentage:");
            double percentage = double.Parse(Console.ReadLine());

            Employees employeeToReceiveIncrease = employees.Find(employee => employee.Id == employeeIdToReceiveIncrease);

            if (employeeToReceiveIncrease != null)
            {
                employeeToReceiveIncrease.SallaryIncreaser(percentage);
                Console.WriteLine("Salary increased successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }

            Console.WriteLine("Updated list of employees:");

            foreach (Employees employeesToBeOutputted in employees)
            {
                Console.WriteLine(employeesToBeOutputted);
                Console.WriteLine();
            }

        }
    }
}