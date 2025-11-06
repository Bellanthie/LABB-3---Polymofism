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
        public string Name { get; set; }

        public override double Area()
        {
            SideLength * SideLength;

        }


    }
}
