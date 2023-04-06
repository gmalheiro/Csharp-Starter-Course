using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrturaSequencial
{
    public class Radius
    {
        private static double _radius;

        public static double RadiusCircle
        {
            get { return _radius; }
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius must be a positive integer");
                }
            }
        }

        public static double AreaCirculo(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CircunferenciaCirculo(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double VolumeEsfera(double radius)
        {
            return (4 * Math.PI * Math.Pow(radius, 3)) / 3;
        }       
    }
}
