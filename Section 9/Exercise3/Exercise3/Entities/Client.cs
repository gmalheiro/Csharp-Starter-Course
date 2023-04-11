using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
            
        }

        public Client(string name, string email, DateTime birhtDate )
        {
            Name = name;
            Email = email;
            BirthDate = birhtDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( Name );
            sb.Append(" (");
            sb.Append( BirthDate.ToString() );

            sb.Append(") - ");
            sb.Append( Email );

            return sb.ToString();
        }

    }
}
