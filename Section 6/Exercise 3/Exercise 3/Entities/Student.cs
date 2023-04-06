using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Entities
{
    public class Student
    {
        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; set; }
        public string Email { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}";
        }
    }
}
