namespace CSharpConcepts.SOLID.Fix
{
    /*
     * To adhere to ISP, we can split the IWorker interface into smaller, more specific interfaces.
    */

    // Specific interfaces for different behaviors
    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }

    // OfficeWorker implements both IWorkable and IEatable
    public class OfficeWorker : IWorkable, IEatable
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

    // Robot implements only IWorkable
    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}
