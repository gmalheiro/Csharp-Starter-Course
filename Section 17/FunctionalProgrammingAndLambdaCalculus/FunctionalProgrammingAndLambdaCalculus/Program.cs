namespace FunctionalProgrammingAndLambdaCalculus
{
    public class Program
    {
        public static int globalValue = 3;
        // Lambda Calculus = Mathematical formalism base of functional programming
        // Lambda Expressions = Anonymous functions of first class (can be passed as arguments, returned from functions, assigned to variables)
        static void Main(string[] args)
        {
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Array.Sort(vect);
            Console.WriteLine(string.Join(" ", vect));
        }

        public static void ChangeOddValues(int[] numbers)
        {
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
    }
}