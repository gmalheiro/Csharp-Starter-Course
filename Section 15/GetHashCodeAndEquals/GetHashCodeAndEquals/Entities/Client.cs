using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeAndEquals.Entities
{
    public class Client
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public override int GetHashCode()
        {
            return Email?.GetHashCode() ?? -1 ; 
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client ?? new Client() { Name = "", Email = ""};   
            return Email?.Equals(other.Email) ?? throw new Exception("Email is null or empty");
        }
    }
}
