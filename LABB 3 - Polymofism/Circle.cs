using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymofism
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }
        public double Diameter => 2 * Radius;

        public Circle(double Radius, string Color, bool isFilled)
            : base(color, isFilled)
        {
            Radius = radius;
        }

        public override double Area()
        {
            Math.PI* Radius *Radius;

        }
    }
}
