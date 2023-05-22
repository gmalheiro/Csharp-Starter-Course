using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance.Entities
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Printer processing the document: " + doc); ;
        }

        public void Print(string doc)
        {
            Console.WriteLine("Printer processing: " + doc);
        }
    }
}
