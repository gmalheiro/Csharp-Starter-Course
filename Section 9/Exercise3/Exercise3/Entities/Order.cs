using Exercise3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
            
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment:");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status:");
            sb.AppendLine(Status.ToString());
            sb.Append("Client:");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order itemss:");
            
            foreach (var item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", $");
                sb.Append(item.Price);
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(item.SubTotal().ToString());
            }
            sb.Append("Total Price: $");
            sb.Append(Total().ToString("F2"));

            return sb.ToString();
        }
    }
}
