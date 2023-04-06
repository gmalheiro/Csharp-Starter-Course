using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaWhile.Exercises
{
    public class FavoriteFuel
    {
        public static void Fuel()
        {
            int choice = 0;
            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;

            while (choice != 4)
            {
                Console.Write($" Which fuel do you prefer" +
                              $"\n 1- Alcohol" +
                              $"\n 2- Gasoline" +
                              $"\n 3- Diesel" +
                              $"\n Type the number:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        alcohol++;
                        break;
                    case 2:
                        gasoline++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    default:
                        Console.WriteLine("Thank you");
                        break;
                }
            }
            Console.WriteLine($" Alcohol:{alcohol}" +
                              $"\n Gasoline:{gasoline}" +
                              $"\n Diesel:{diesel}");
        }
    }
}
