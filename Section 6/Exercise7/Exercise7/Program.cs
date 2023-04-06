namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            //Will output the total of elements
            Console.WriteLine(mat.Length);

            //Will output the number of rows
            Console.WriteLine(mat.Rank);

            //Will output the number of rows 
            Console.WriteLine(mat.GetLength(0));

            //Will output the number of columns
            Console.WriteLine(mat.GetLength(1));

        }
    }
}