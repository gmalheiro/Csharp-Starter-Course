using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance.Entities
{
    public abstract class Device
    {
        public String? SerialNumber { get; set; }

        public abstract void ProcessDoc(string doc);
    }
}
