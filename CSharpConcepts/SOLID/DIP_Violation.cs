namespace CSharpConcepts.SOLID.Violation
{
    /*
     * Idea: Suppose we have a class FileLogger that logs messages to a file and a class Application that uses 
     * FileLogger to log information:
    */

    /*
     * Problems:
     * The Application class directly depends on the FileLogger class. If we wanted to change the logging 
     * mechanism (e.g., to a database logger), we would need to modify the Application class, violating 
     * the Open/Closed Principle and making the design less flexible.
    */

    public class FileLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log to file: {message}");
            // Actual file writing logic would go here.
        }
    }

    public class Application
    {
        private FileLogger _logger;

        public Application()
        {
            _logger = new FileLogger(); // Direct dependency on FileLogger
        }

        public void DoWork()
        {
            _logger.Log("Work is being done.");
        }
    }
}
