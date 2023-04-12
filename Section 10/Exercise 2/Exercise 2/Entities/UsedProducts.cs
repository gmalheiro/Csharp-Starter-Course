using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Entities
{
    public class UsedProducts : Products
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProducts()
        {
            
        }

        public UsedProducts(string Name, double Price, DateTime manufactureDate) : base(Name, Price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append(" (used) $ ");
            stringBuilder.Append(Price.ToString("F2"));
            stringBuilder.Append(" (Manufacture date: ");
            stringBuilder.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }

    }
}
