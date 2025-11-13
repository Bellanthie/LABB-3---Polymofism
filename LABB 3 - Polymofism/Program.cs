using LABB_3___Polymorfism;

namespace LABB_3___Polymofism
// ** Här skapar man nya objekt**
{
    public class Program
    {
        static void Main(string[] args)
        {
            Geometry rectangle = new Rectangle(5, 10);
            Geometry square = new Square(4, 8);
            Geometry circle = new Circle();

            Console.WriteLine($"Rectangle area: {rectangle.Area()}");
            Console.WriteLine($"Square area: {square.Area()}");
            Console.WriteLine($"Circle area: {circle.Area()}");

            List<Geometry> GeometryList = [rectangle, square, circle];
            foreach (var form in GeometryList)
            {
                form.Area();
                Console.WriteLine($"The area of {form.GetType().Name} is {form.Area()}");
            }


            /* I need to implement the loop that goes through each objecktreference and calls
             * the respective method of said objekt.
             * I need to implement the result av AREA calculation for each objeckt.
             * */


        }
    }
}