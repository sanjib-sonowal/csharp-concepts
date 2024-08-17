namespace CSharpConcepts.SOLID.Violation
{
    /*
     * Violation: The Penguin class also inherits from Bird, but it throws an exception in the Fly method 
     * because penguins can't fly. This violates the LSP because replacing a Bird object with a Penguin object 
     * breaks the program's expected behavior.
    */

    // Base class
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }

    // Subclass that adheres to LSP
    public class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying!");
        }
    }

    // Subclass that does NOT adhere to LSP (Example)
    public class Penguin : Bird
    {
        // Penguins cannot fly, so this violates LSP
        public override void Fly()
        {
            throw new NotImplementedException("Penguins cannot fly!");
        }
    }
}
