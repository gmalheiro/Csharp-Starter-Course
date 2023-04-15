using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4.Entities
{
    public class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual()
        {
            
        }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = AnnualIncome > 2000 ? (AnnualIncome * 0.25) - (HealthExpenditures * 0.5) : (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
            return tax;
        }


    }
}
