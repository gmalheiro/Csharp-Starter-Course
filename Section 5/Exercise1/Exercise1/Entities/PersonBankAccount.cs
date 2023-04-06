using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Entities
{
    public class PersonBankAccount
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public PersonBankAccount()
        {   
            Name = string.Empty;
            AccountNumber = 0;
            Balance = 0;
        }

        public PersonBankAccount(string name, int accountNumber, double balance) : this() 
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public override string ToString()
        {
            return $" Account:{AccountNumber}\n" +
                   $" Owner:{Name}\n" +
                   $" Balance:{Balance}" ;
        }

    }
}
