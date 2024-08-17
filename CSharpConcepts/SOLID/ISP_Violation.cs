namespace CSharpConcepts.SOLID.Violation
{
    /*
     * Idea: Suppose we have a general interface IWorker that forces all worker classes to implement methods that 
     * they might not need.
    */

    /*
     * Problems:
     * The Robot class is forced to implement the Eat method even though it doesn't need it.
     * This violates the Interface Segregation Principle because the IWorker interface is too broad, forcing classes to implement methods they don't use.
    */

    public interface IWorker
    {
        void Work();
        void Eat();
    }

    public class OfficeWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Office worker is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Office worker is eating lunch.");
        }
    }

    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }

        public void Eat()
        {
            // Robots don't eat, but they are forced to implement this method.
            throw new NotImplementedException();
        }
    }
}
