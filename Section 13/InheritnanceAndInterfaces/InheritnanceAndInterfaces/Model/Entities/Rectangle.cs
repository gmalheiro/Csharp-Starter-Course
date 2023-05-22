using InheritnanceAndInterfaces.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritnanceAndInterfaces.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public Rectangle()
        {
            
        }

        public Rectangle(double width, double height,Color color)
        {
            Width = width;
            Height = height;    
            Color = color;  
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Color = {Color} , Width : {Width}, Height : {Height}, Area : {Area().ToString("F2")}" ;
        }
    }
}
