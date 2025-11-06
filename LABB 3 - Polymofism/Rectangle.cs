using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymofism
{

    public class Rectangle : Geometry
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor
        public Rectangle(double width, double height, string color, bool isFilled)
            : base(color, isFilled)
        {
            Width = width;
            Height = height;
        }

        public override Area()
        {
            Width * Height;
        }
    }
}
