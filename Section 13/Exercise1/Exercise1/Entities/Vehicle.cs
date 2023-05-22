using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Entities
{
    public class Vehicle
    {
        public string? Model { get; set; }

        public Vehicle()
        {
            
        }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
