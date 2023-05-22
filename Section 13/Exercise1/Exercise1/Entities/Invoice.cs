using Exercise1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get; set; }

        public Invoice()
        {
            
        }

        public Invoice(double basicPayment, double tax, double totalPayment)
        {
            BasicPayment = basicPayment;
            Tax = tax;
            TotalPayment = totalPayment;
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment}" +
                   $"\nTax: {Tax}" +
                   $"\nTotal payment: {TotalPayment}";
        }

    }
}
