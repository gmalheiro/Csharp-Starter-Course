using Exercise_2.Entities;
using Exercise_2.Utilities;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees firstEmployee = new Employees();
            Employees secondEmployee = new Employees();

            Console.WriteLine("First employee data:");
            Console.Write("Name:");
            firstEmployee.Name = Console.ReadLine();
            Console.Write("Sallary:");
            firstEmployee.Sallary = double.Parse(Console.ReadLine()) ;

            Console.WriteLine("Second employee data:");
            Console.Write("Name:");
            secondEmployee.Name = Console.ReadLine();
            Console.Write("Sallary:");
            secondEmployee.Sallary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Average Sallary: {SallaryCalculator.AverageSallary(firstEmployee.Sallary,secondEmployee.Sallary).ToString("F2")}");
        }
    }
}