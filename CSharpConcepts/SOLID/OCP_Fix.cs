namespace CSharpConcepts.SOLID.Fix
{
    /*
     * To adhere to OCP, we can introduce an interface or an abstract class that all shapes will implement. 
     * This way, AreaCalculator doesn't need to change when a new shape is added.
    */

    // Shape interface
    public interface IShape
    {
        double CalculateArea();
    }

    // Circle class implementing IShape
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle class implementing IShape
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    // AreaCalculator class that is now open for extension but closed for modification
    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
