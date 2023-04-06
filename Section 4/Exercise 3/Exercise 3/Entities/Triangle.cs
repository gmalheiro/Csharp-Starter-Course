using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Entities
{
    public class Triangle
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get { return _sideA; }
            set { _sideA = value; }
        }
        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }
        
        public double SideC
        {
            get { return _sideC; }
            set {_sideC = value;}
        }

        public double TriangleArea()
        {
            double p = (SideA + SideB + SideC) / 2.0;
            double sqrdRoot = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC) );

            return sqrdRoot;
        }

    }
}
