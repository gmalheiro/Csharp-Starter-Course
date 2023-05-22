using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Entities
{
    public class Installments
    {
        //Uma lista de installments na classe que vai ter isso como propriedade
        public DateTime DueDate { get; set; }
        public double InstallmentValue { get; set; }
        public Installments() { }

        public Installments(DateTime dueDate, double installmentValue)
        {
            DueDate = dueDate;
            InstallmentValue = installmentValue;
        }

        public override string ToString()
        {
            return $"{DueDate} - {InstallmentValue.ToString("F2")}";
        }
    }
}
