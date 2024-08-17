namespace CSharpConcepts.SOLID.Fix
{
    /*
     * Fix: To adhere to the LSP, we should avoid having subclasses that cannot fulfill the behavior promised 
     * by the base class. One way to fix this is by not having a Fly method in the base Bird class and instead 
     * using an interface or another abstraction to represent flying behavior.
    */

    // Interface representing flying behavior
    public interface IFlyable
    {
        void Fly();
    }

    // Base class
    public class Bird
    {
        // Common bird properties and methods
    }

    // Subclass that can fly
    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying!");
        }
    }

    // Subclass that cannot fly
    public class Penguin : Bird
    {
        // Penguins do not implement IFlyable
    }
}
