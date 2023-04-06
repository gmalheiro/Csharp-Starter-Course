using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Entities
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; } 
            set { _age = value; }
        }

        public static string OldestPerson(string FirstPersonName, string SecondPersonName, int FirstPersonAge, int SecondPersonAge)
        {
            return FirstPersonAge >= SecondPersonAge ? FirstPersonName : SecondPersonName;
        }
    }
}
