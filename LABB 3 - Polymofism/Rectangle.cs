using LABB_3___Polymorfism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymorfism
{
    //  Subclass 'Rectangle' to Geometry
    public class Rectangle : Geometry
    {
        // Rectangle Properties
        public double Width { get; set; }
        public double Height { get; set; }

        // Rectangle Constructor
        public Rectangle()

        {
            Width = 5;
            Height = 3;
        }

        // Rectangle's method: Area
        public override double Area()
        {
            return Width * Height;
        }
    }
}
