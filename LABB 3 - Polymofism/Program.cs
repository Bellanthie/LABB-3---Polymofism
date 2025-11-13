namespace LABB_3___Polymofism
{
    public class Geometry
    {
        //Attributes
        public string color { get; set; }
        public bool isFilled { get; set; }

        // Constructor
        public Geometry(double Radius, double Diameter, double SideLength, string Name, double Width, double Height, string Color, bool isFilled)
            : base(color, isFilled)
        {
            Color = color;
            isFilled = isFilled;
        }

        public Geometry(string color, bool isFilled)
        {
            this.color = color;
            this.isFilled = isFilled;
        }

        // Add a virtual Area method to be overridden by derived classes
        public virtual double Area()
        {
            return 0;
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10, "Blue", true);
            Square square = new Square(4, "PerfectSquare", "Red", false);
            Circle circle = new Circle(3, "Green", true);

            Console.WriteLine($"Rectangle area: {rect.Area()}");
            // Assuming Square and Circle also have Area() methods
            Console.WriteLine($"Square area: {square.Area()}");
            Console.WriteLine($"Circle area: {circle.Area()}");
            Console.WriteLine($"Circle color: {circle.color}");

            /* I need to implement the loop that goes through each objecktreference and calls
             * the respective method of said objekt.
             * I need to implement the result av AREA calculation for each objeckt.
             * */

            
        }
    }
}