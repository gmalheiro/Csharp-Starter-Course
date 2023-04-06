using Exercise1.Entities;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            Person secondPerson = new Person();

            Console.Write("Enter First person name:");
            firstPerson.Name = Console.ReadLine();

            Console.Write("Enter First person age:");
            firstPerson.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Second person name:");
            secondPerson.Name = Console.ReadLine();

            Console.Write("Enter Second person age:");
            secondPerson.Age = int.Parse(Console.ReadLine());
                        

            Console.WriteLine($"The oldest person is: {Person.OldestPerson(firstPerson.Name,secondPerson.Name,firstPerson.Age,secondPerson.Age)}");

        }
    }
}