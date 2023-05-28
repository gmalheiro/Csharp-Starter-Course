﻿namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller (Seller seller)
        {
            if (seller == null)
            {
                throw new ArgumentNullException(nameof(seller));
            }

            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            var totalSales = Sellers.Sum(seller => seller.TotalSales(initial,final));
            return totalSales;
        }

    }
}
