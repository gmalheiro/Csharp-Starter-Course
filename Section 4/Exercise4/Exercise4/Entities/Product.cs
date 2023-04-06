using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4.Entities
{
    public class Product
    {
        private string _name;
        private double _price;
        private int _quantity;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price 
        { 
            get { return _price; } 
            set {  _price = value; } 
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double TotalInStock()
        {
            return Price * Quantity ;
        }

        public void AddProducts(int productsQuantity)
        {
            Quantity += productsQuantity;
        }

        public void RemoveProducts(int productsQuantity)
        {
            Quantity -= productsQuantity;
        }

        public override string ToString()
        {
            return ($"{Name}, \n${Price.ToString("F2")}, \n{Quantity} Units, \nTotal value in stock: ${TotalInStock()} ");
            
        }
    }
}
