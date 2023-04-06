using Exercise_3.Entities;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            Console.Write("How many rooms will be rented?");
            int n  = int.Parse(Console.ReadLine()); 

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent:{i}");
                Console.Write($"Name:");
                string name = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Room:");
                int room =  int.Parse(Console.ReadLine());
                students[room] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms");
            for (int i = 1;i < 10; i++)
            {
                if (students[i] != null)
                {
                    Console.WriteLine($"{i} : {students[i]}");
                }
            }

        }
    }
}