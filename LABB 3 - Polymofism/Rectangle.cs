using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymofism
{
    //  Subclass 'Rectangle' to Geometry
    public class Rectangle : Geometry
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor
        public Rectangle(double width, double Height, string color, bool isFilled)
            : base(color, isFilled)
        {
            Width = 5;
            Height = 3;
        }

        // Rectangles method: Area
        public override double Area()
        {
            return Width * Height;
        }
    }
}
