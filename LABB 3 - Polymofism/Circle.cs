using LABB_3___Polymorfism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymorfism
{
    public class Circle : Geometry
    {
        //public properties and methods = PascalCase
        //parameters and local variable = camelCase
        //private fields = _camelCase (_radius)
        public double Radius { get; set; } // Circle property
       
 
        // Circle constructor without parameters.
        // Initializes the instance with the set Radius '6'
        // Geometry has a constructor that accepts (string color, bool isFilled).
        public Circle()
        {
            Radius = 6;
        }

        // Method that calculates area.
        // Return type must be a numeric type (double). Match the base class signature.
        // Override used to implement Circle's OWN calculation when called upon
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
