using System;
using System.Collections.Generic; // i dont understand why these two are grey OR if i need both of these at all?
using LABB_3___Polymorfism;

namespace LABB_3___Polymorfism
// ** Här skapar man nya objekt**
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Object instances of Geometry (references)
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();
            Geometry circle = new Circle();

            List<Geometry> GeometryList = new List<Geometry> { rectangle, square, circle };
            foreach (var form in GeometryList)
            {
                form.Area();
                Console.WriteLine($"The area of {form.GetType().Name} is {Math.Round(form.Area())}");
            }
        }
    }
}