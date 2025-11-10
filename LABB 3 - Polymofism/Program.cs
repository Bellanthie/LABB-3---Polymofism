namespace LABB_3___Polymofism
{
    public class Geometry
    {
        //Attributes
        public string color { get; set; }
        public bool isFilled { get; set; }


        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10, "Blue", true);
            Square square = new Square(4, "PerfectSquare", "Red", false);
            Circle circle = new Circle(3, "Green", true);

            Console.WriteLine($"Rectangle area: {rect.Area()}");
            Console.WriteLine($"Square sidelength: {square.SideLength()}");
            Console.WriteLine($"Circle color: {circle.Color}");


            
        }
    }
}
