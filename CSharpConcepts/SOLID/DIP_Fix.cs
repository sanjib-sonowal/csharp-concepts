using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.SOLID.Fix
{
    /*
     * To adhere to DIP, we can introduce an abstraction (interface) that both the FileLogger and any other 
     * future loggers will implement. The Application class will then depend on this abstraction rather than 
     * a specific implementation.
    */

    // Logger abstraction
    public interface ILogger
    {
        void Log(string message);
    }

    // Concrete implementation of ILogger for file logging
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log to file: {message}");
            // Actual file writing logic would go here.
        }
    }

    // Another concrete implementation of ILogger for database logging
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log to database: {message}");
            // Actual database writing logic would go here.
        }
    }

    // Application class depends on abstraction (ILogger) rather than concrete implementation
    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger; // Dependency injected via constructor
        }

        public void DoWork()
        {
            _logger.Log("Work is being done.");
        }
    }
}
