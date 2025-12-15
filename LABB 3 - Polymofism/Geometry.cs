using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymorfism
{
    // PARENT CLASS--> GEOMETRY (childclasses: circle, square, rectangle)
    public class Geometry
    {
        // Virtual method to be overridden
        // Base method that childclasses: circle, square, rectangle can override.
        public virtual double Area()
        {
            return 0;
        }
    }
}
