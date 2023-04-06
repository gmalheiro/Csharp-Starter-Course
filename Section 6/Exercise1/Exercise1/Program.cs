namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double averageHeight = 0.0 ;

            double[] doublesArray = new double[n];

            double doublesSum = 0;

            for (int i = 0; i < doublesArray.Length; i++)
            {
                doublesArray[i] = double.Parse(Console.ReadLine());
                doublesSum += doublesArray[i];
            }
            averageHeight = doublesSum / n;

            Console.WriteLine(averageHeight);


        }
    }
}