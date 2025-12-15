using LABB_3___Polymorfism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymorfism
{
    public class Square : Geometry
    {
        // Square properties
        public double SideLength { get; set; } 
        public double HeightLength { get; set; }

        // Square Constructor without parameters
        public Square()
        {
            SideLength = 7;
            HeightLength = 4;
        }

        // Square OWN method is set to override, in order to use ITS OWN calculation method in place of Geometry's
        public override double Area()
        {
            return SideLength * HeightLength;
        }
    }
}
