using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1.Entities.Exception
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) 
        {
            
        }
    }
}
