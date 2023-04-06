using System.Net.WebSockets;

namespace Exercise8
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 3;
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.Write("How many lines and rows the array will have:");
            int linesNRows = int.Parse(Console.ReadLine());

            int[,] mat = new int[linesNRows, linesNRows];

            int[] mainDiagonal = new int[linesNRows];
            int negativeNumbers = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Type a number:");
                    int numberToBeInsideTheArray = int.Parse(Console.ReadLine());
                    mat[i, j] = numberToBeInsideTheArray;

                    if (i == j)
                    {
                        mainDiagonal[i] = numberToBeInsideTheArray;
                    }
                    if (numberToBeInsideTheArray < 0)
                    {
                        negativeNumbers++;
                    }
                }
            }

            Console.WriteLine("Main diagonal");
            foreach (var item in mainDiagonal)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nNegative numbers = {negativeNumbers}");

        }
    }
}