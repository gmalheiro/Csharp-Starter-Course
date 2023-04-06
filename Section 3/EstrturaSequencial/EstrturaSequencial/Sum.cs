using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrturaSequencial
{
    public class Sum
    {
        private static int _numberOne;

        public static int NumberOne
        {
            get { return _numberOne; }
            set
            {
                if (value >= 0) // check if the new value is greater than or equal to zero
                {
                    _numberOne = value; // set the new value to the private field
                }
                else
                {
                    throw new ArgumentException("NumberOne must be a positive integer"); // throw an exception if the new value is invalid
                }
            }
        }


        private static int _numberTwo;

        public static int NumberTwo
        {
            get { return _numberTwo; }
            set
            {
                if (value >= 0)
                {
                    _numberTwo = value;
                }
                else
                {
                    throw new ArgumentException("NumberOne must be a positive integer");
                }

            }
        }
        
        public static int Add (int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    
    }
}
