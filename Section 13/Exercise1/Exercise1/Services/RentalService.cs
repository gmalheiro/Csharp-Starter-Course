using Exercise1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Services
{
    public class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }
        
        private ITaxService?  _taxService ;

        public RentalService()
        {
            
        }

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.ReturnDate.Subtract(carRental.PickupDate);

            double basicPayment = 0.0;
            
            if (duration.TotalHours >= 12)
            {
                // Tá dando erro nessa parte do dia
                // Está dando negativo
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
                double tax = _taxService!.Tax(basicPayment);
                double totalPayment = basicPayment + tax;

                carRental.Invoice = new Invoice(basicPayment,tax,totalPayment);
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerHour;
                double tax = _taxService!.Tax(basicPayment);
                double totalPayment = basicPayment + tax;

                carRental.Invoice = new Invoice(basicPayment, tax, totalPayment);
            }
        }

    }
}
