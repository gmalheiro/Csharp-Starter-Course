using System;

namespace EstrturaSequencial// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which exercise you want to:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
                {
                case 1:
                    Console.Write("Enter the radius of the circle:");
                    double raio = double.Parse(Console.ReadLine());
                    Console.Write("Area: {0}", Radius.AreaCirculo(raio).ToString("F4"));
                    break;
                case 2:
                    Console.Write("Enter the first number:");
                    int numberOne = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second number:");
                    int numberTwo = int.Parse(Console.ReadLine());
                    Console.Write("Sum: {0}", Sum.Add(numberOne, numberTwo));
                    break;
                case 3:
                    Console.Write("Type Letter A:");
                    int A = int.Parse(Console.ReadLine());
                    Console.Write("Type Letter B:");
                    int B = int.Parse(Console.ReadLine());
                    Console.Write("Type Letter C:");
                    int C = int.Parse(Console.ReadLine());
                    Console.Write("Type Letter D: ");
                    int D = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Difference: {Difference.MakeDifference(A,B,C,D)}");
                    break;

                
                default:
                    Console.Write("Invalid choice");
                    break;
            }   

        }
    }
}