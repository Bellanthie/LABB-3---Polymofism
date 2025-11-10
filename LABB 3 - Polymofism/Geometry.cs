using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB_3___Polymorfism
{
    public class Geometry
    {
        public string color { get; set; }
        public bool isFilled { get; set; }

        // Virtual method to be overridden
        public virtual double Area()
        {
            return 0;
        }

        private static void Main(string[] args)
        {

        }
    }
}
