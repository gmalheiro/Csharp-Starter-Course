﻿using Exercise3.Entities;
using Exercise3.Entities.Enums;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth Date(DD/MM/YYYY):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name,email,birthDate);

            Console.WriteLine("Enter Order data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order?");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now,status,client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter ${i} item data:");
                Console.Write("Product name:");
                string productName = Console.ReadLine();
                Console.Write("Product price:");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName,productPrice);
                OrderItem orderItem = new OrderItem(quantity,productPrice,product);
                order.AddItem(orderItem);
                Console.Clear();
            }

            Console.WriteLine(order.ToString());


        }
    }
}