using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Entities
{
    public class ImportedProducts : Products
    {
        public double CustomFee { get; set; }
        public ImportedProducts()
        {
        }
        public ImportedProducts(double customFee)
        {
            CustomFee = customFee;
        }
        public ImportedProducts(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }
        public double TotalPrice()
        {
            return Price + CustomFee;
        }
        public override string PriceTag()
        {   
           StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append(" $ ");
            stringBuilder.Append(TotalPrice().ToString("F2"));
            stringBuilder.Append(" (Customs fee: $ ");
            stringBuilder.Append(CustomFee.ToString("F2"));
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }
    }
}
