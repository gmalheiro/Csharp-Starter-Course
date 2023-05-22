using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Entities
{
    public class Contracts
    {
        public int ContractNumber { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installments> Installment { get; set; }

        public Contracts()
        {
            Installment = new List<Installments>();
        }

        public Contracts(int contractNumber, DateTime date, double value)
        {
            ContractNumber = contractNumber;
            Date = date;
            TotalValue = value;
            Installment = new List<Installments>();
        }

        public void AddInstallment(Installments installment)
        {
            Installment.Add(installment);
        }
    }
}
