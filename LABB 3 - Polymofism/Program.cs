namespace LABB_3___Polymofism
        // ** Här skapar man nya objekt**
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10, "Blue", true);
            Square square = new Square(4, 8, "Red", false);
            Circle circle = new Circle(3, "Green", true);

            Console.WriteLine($"Rectangle area: {rect.Area()}");
            Console.WriteLine($"Square area: {square.Area()}");
            Console.WriteLine($"Circle area: {circle.Area()}");


            /* I need to implement the loop that goes through each objecktreference and calls
             * the respective method of said objekt.
             * I need to implement the result av AREA calculation for each objeckt.
             * */

            
        }
    }
}