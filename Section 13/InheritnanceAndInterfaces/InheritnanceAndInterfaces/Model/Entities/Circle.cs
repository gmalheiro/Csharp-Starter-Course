using InheritnanceAndInterfaces.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritnanceAndInterfaces.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle()
        {
            
        }

        public Circle(double radius, Color color)
        {
            Radius = radius;
            Color = color;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Circle color = {Color}, radius = {Radius}, Area = {Area().ToString("F2")}";
        }
    }
}
