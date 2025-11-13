using System;

namespace LABB_3___Polymofism
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }
        public double Diameter => 2 * Radius;

        // Use lowercase parameter names to avoid confusion with properties.
        // Assume Geometry has a constructor that accepts (string color, bool isFilled).
        public Circle(double radius, string color, bool isFilled)
            : base(color, isFilled)
        {
            Radius = 6;
        }

        // Return type must be a numeric type (double). Match the base class signature.
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
