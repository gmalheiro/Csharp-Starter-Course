using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCondicional
{
    public class MultiplesOrNot
    {
        public static string MultipleOrNot(int Number1, int Number2)
        {
            return ((Number1 % Number2 == 0) ? "They are multiples" : "They aren't multiples");
        }
    }
}
