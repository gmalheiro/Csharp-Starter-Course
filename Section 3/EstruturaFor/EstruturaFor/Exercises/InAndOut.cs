using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaFor.Exercises
{
    public class InAndOut
    {
        public static void NumberInOrOut()
        {
            Console.Write("Type a number:");
            int numberToRepeat = int.Parse(Console.ReadLine());

            int numberIn = 0;
            int numberOut = 0;

            for (int i = 0; i < numberToRepeat; i++)
            {
                Console.Write("Type a number:");
                int number = int.Parse(Console.ReadLine()); 

                if(number >= 10 &&  number <= 20)
                {
                    numberIn++;
                }
                else
                {
                    numberOut++;
                }

            }

            Console.Write($"{numberIn} in\n" +
                          $"{numberOut} out");


        }
    }
}
