using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Entities
{
    public class CarRental
    {
        public Vehicle? Vehicle { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Invoice? Invoice { get; set; }

        public CarRental()
        {
            
        }

        public CarRental(Vehicle vehicle, DateTime pickupDate, DateTime returnDate)
        {
            Vehicle = vehicle;
            PickupDate = pickupDate;
            ReturnDate = returnDate;
            Invoice = null;
        }


    }
}
