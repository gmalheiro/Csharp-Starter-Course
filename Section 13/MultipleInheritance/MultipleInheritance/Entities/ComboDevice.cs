using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance.Entities
{
    public class ComboDevice : Device, IPrinter,IScanner
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("ComboDevice is processing the document:" + doc); ;
        }

        public void Print(string doc)
        {
            Console.WriteLine("ComboDevice print " + doc);
        }


        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
