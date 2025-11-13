using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymofism
{
    public class Square : Geometry
    {
        public double SideLength { get; set; }
        public double HeightLength { get; set; }

        // Constructor
        public Square(double sideLength, double heightLength, string color, bool isFilled)
            : base(color, isFilled)
        {
            SideLength = 7;
            HeightLength = 4;
        }

        public override double Area()
        {
            return SideLength * HeightLength;
        }
    }
}
