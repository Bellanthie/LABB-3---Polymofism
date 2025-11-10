using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymorfism
{
    // Attributes below: also variables of subclasses: Rectangle, Square, Circle
    public abstract class Geometry
    {
        public double Radius { get; set; } = 5;
        public double Diameter { get; set; } = 7;
        public double SideLength { get; set; } = 2;
        public string Name { get; set; } = "No Sqare name yet";
        public double Height { get; set; } = 3;
        public double Width { get; set; } = 3;
        public string Color { get; set; } = "Yellow";
        public bool isFilled { get; set; } = true;



    }
}
