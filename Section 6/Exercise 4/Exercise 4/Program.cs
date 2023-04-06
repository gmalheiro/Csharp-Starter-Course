using Exercise_4.Utilities;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2,3,3);
            Console.WriteLine(s1);

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int triple;
            Calculator.Triple(b, out triple);
            Console.WriteLine(triple);

            string[] names = new string[] {"Maria","Alex","Bob"};
            foreach(string name in names)
            {
                Console.WriteLine( name);
            }


        }
    }
}