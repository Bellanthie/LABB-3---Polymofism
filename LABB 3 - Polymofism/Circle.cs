using LABB_3___Polymorfism;
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
       
        // Use lowercase parameter names to avoid confusion with properties.
        // Assume Geometry has a constructor that accepts (string color, bool isFilled).
        public Circle()
        {
            Radius = 6;
        }

        // Return type must be a numeric type (double). Match the base class signature.
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
