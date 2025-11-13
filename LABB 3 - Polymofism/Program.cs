using LABB_3___Polymorfism;

namespace LABB_3___Polymofism
// ** Här skapar man nya objekt**
{
    public class Program
    {
        static void Main(string[] args)
        {
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();
            Geometry circle = new Circle();

            List<Geometry> GeometryList = [rectangle, square, circle];
            foreach (var form in GeometryList)
            {
                form.Area();
                Console.WriteLine($"The area of {form.GetType().Name} is {Math.Round(form.Area())}");
            }

        }
    }
}