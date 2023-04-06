using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCondicional
{
    public class OddOrEven
    {
        public static string NumberOddOrEven(int Number)
        {
            return (Number % 2 == 0 ) ? "It's even" : "It's odd";
        }
    }
}
