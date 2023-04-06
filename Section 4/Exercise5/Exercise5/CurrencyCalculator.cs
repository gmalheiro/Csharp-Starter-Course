using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class CurrencyCalculator
    {
        public static double DollarCurrencyCalculator(double DollarPrice, double amount)
        {
            double iof = (DollarPrice * amount) * 0.06;
            return DollarPrice * amount + iof ;
        }
    }
}
