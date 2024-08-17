namespace CSharpConcepts.SOLID.Violation
{
    /*
     * Suppose we have a class that calculates the area of different shapes.
    */

    /*
     * Problems:
     * The AreaCalculator class needs to be modified whenever a new shape is introduced.
     * This violates the Open/Closed Principle because the class is not closed for modification.
    */

    public class AreaCalculator
    {
        public double CalculateArea(object shape)
        {
            if (shape is Circle)
            {
                Circle circle = (Circle)shape;
                return Math.PI * circle.Radius * circle.Radius;
            }
            else if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                return rectangle.Width * rectangle.Height;
            }

            throw new ArgumentException("Unknown shape");
        }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
