using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Entities
{
    public class Employees
    {
        private string _name;
        private double _sallary;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Sallary
        {
            get { return _sallary; }
            set { _sallary = value; }
        }

    }
}
