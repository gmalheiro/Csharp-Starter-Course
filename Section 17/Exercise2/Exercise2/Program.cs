using Exercise2.Entities;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path:");
            string? path = Console.ReadLine();

            Console.Write("Enter salary:");
            double salary = double.Parse(Console.ReadLine()!);

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path!))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine()!;
                        string[] employee = line?.Split(",")!;
                        string employeeName = employee[0];
                        string employeeEmail = employee[1];
                        double employeeSalary = double.Parse(employee[2]);
                        employees.Add(new Employee(employeeName, employeeEmail, employeeSalary));
                    }
                }

                var employeesMailWithGreaterSalary = employees.Where(e => e.Salary > salary).OrderBy(e => e.Name).Select(e => e.Email).ToList();

                Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2")}");
                employeesMailWithGreaterSalary.ForEach(e => Console.WriteLine(e));

                var sumOfMsSalary = employees.Where(e => e.Name![0] == 'M').Select(e => e.Salary).Sum();
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumOfMsSalary.ToString("F2"));

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}