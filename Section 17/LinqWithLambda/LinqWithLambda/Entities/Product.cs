﻿namespace LinqWithLambda.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }

        public Category? Category { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, double price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Price.ToString("F2")}, {Category?.Name ?? "Category is null or empty"}, {Category ? .Tier ?? 0}";
        }
    }
}