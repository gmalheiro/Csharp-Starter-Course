using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaFor.Exercises
{
    public class ForOddOrEven
    {
        public static void OddOrEven()
        {
            Console.Write("Type a number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(i);   
                }
            }
        }
    }
}
