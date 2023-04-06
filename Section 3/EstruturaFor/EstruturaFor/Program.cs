using EstruturaFor.Exercises;

namespace EstruturaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Which exercise you want to see in action" +
                          $"\n 1- Odd or even" +
                          $"\n 2- In and out" +
                          $"\n 3- Weighted average\"");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ForOddOrEven.OddOrEven();
                    break;

                case 2:
                    Console.Clear();
                    InAndOut.NumberInOrOut();
                    break;

                case 3:
                    Console.Clear();
                    ForWeightedAverage.WeightedAverage();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }


    }
    }
