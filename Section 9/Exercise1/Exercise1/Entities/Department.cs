using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Entities
{
    public class Department
    {
        public string Name { get; set; }

        public Department()
        {
            
        }

        public Department(string name)
        {
            Name = name;
        }

    }
}
