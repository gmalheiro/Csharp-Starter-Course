using Exercise_1.Entities;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee {i} data:");
                Console.Write("Outsourced (y/n)? ");
                string outsourcedOrNot = Console.ReadLine();
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Hours:");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());

                double additionalCharge = 0.0;

                if (outsourcedOrNot == "y") 
                {
                    Console.Write("Additional charge:");
                    additionalCharge = double.Parse(Console.ReadLine());

                    Employee employee = new OutsourcedEmployee(name,hours,valuePerHour,additionalCharge);
                    list.Add(employee);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    list.Add(employee);
                }
            }
            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in list)
            {
                Console.WriteLine($"{employee.Name} - ${employee.Payment()}");
            }
        }
    }
}