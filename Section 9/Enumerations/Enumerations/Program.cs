using Enumerations.Entities;
using Enumerations.Entities.Enums;

namespace Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = order.ToString();

            //Converts a string into an enum
            OrderStatus status = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(status);

        }
    }
}