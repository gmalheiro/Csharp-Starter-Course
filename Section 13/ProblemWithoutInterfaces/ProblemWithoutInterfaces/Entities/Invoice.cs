using ProblemWithoutInterfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemWithoutInterfaces.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment +  Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment :{BasicPayment.ToString("F2")}" +
                   $"\n Tax {Tax.ToString("F2")}" +
                   $"\n Total Payment : {TotalPayment.ToString("F2")}";
        }
    }
}
