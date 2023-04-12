using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Entities
{
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products()
        {
            
        }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append(" $ ");
            stringBuilder.Append(Price.ToString("F2"));

            return stringBuilder.ToString();
        }

    }
}
