using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaWhile.Exercises
{
    public class WrongPassword
    {
        public static void EnterPassword()
        {
            string Password;
            Console.Write("Type a Password:");
            Password = Console.ReadLine();
            while (Password != "2002")
            {
                Console.WriteLine($"Incorrect password. " +
                                  $"\nPlease try again:");
                Password = Console.ReadLine();
            }
            Console.WriteLine("Correct Password");
        }
    }
}
