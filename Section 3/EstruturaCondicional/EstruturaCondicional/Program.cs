namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Problem 1: Negative or Positive" +
                          $"\nProblem 2:Odd or even" +
                          $"\nProblem 3:Multiple or not" +
                          $"\nWhich problem you want to see in action:" );
            int choice = int.Parse( Console.ReadLine() );
            int Number = int.MinValue;

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Type a number:");
                    Number = int.Parse(Console.ReadLine());    
                    Console.WriteLine(NegativeOrPositive.NumberNegativeOrPositive(Number));
                    break;
               case 2:
                    Console.Clear();
                    Console.Write("Type a number:");
                    Number = int.Parse( Console.ReadLine()) ;
                    Console.WriteLine(OddOrEven.NumberOddOrEven(Number));
                    break;
               case 3:
                    Console.Clear();
                    Console.Write("Type a  number:");
                    Number= int.Parse(Console.ReadLine());
                    Console.Write("Type another number:");
                    int Number2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(MultiplesOrNot.MultipleOrNot(Number,Number2));
                    break;
            }
        }
    }
}