using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6.Utilities
{
    public class Employees
    {
        public Employees()
        {
            Id = 1;
            Name = "";
            Sallary = 0;
        }

        public Employees(int id, string name, double sallary) : this() 
        {
            Id = id;
            Name = name;
            Sallary = sallary;
        }

        public int Id{ get; private set; }
        public string Name { get; set; }
        public double Sallary { get; private set; }

        public override string ToString()
        {
            return ($"{Id},{Name},{Sallary}") ;
        }

        public void SallaryIncreaser(double percentage)
        {
            Sallary = ((Sallary * (percentage/100) + Sallary));
        }


    }
}
