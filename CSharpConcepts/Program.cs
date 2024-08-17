using Violation = CSharpConcepts.SOLID.Violation;
using Fix = CSharpConcepts.SOLID.Fix;
using CSharpConcepts.SOLID.Fix;

public class Program
{
    public static void Main(string[] args)
    {
        #region Single Responsibility Principle (SRP) - Fix
        Console.WriteLine("Single Responsibility Principle (SRP) - Fix >>>>>");
        Console.WriteLine("----------------------------------------------------");
        Fix.Employee employee = new Fix.Employee
        {
            Name = "John Doe",
            Position = "Software Engineer",
            Salary = 60000M
        };

        // Calculating bonus
        decimal bonus = employee.CalculateYearlyBonus();
        Console.WriteLine($"Yearly Bonus: {bonus}");

        // Generating report
        Fix.EmployeeReportGenerator reportGenerator = new Fix.EmployeeReportGenerator();
        reportGenerator.GenerateReport(employee);
        Console.WriteLine();
        #endregion

        #region Open-Closed Principle (OCP) - Fix
        Console.WriteLine("Open-Closed Principle (OCP) - Fix >>>>>");
        Console.WriteLine("----------------------------------------------------");
        IShape circle = new Circle { Radius = 5 };
        IShape rectangle = new Rectangle { Width = 4, Height = 6 };

        AreaCalculator calculator = new AreaCalculator();

        Console.WriteLine($"Area of Circle: {calculator.CalculateArea(circle)}");
        Console.WriteLine($"Area of Rectangle: {calculator.CalculateArea(rectangle)}");
        Console.WriteLine();
        #endregion

        #region Liskov Substitution Principle (LSP) - Violation
        Console.WriteLine("Executing Liskov Substitution Principle (LSP) - Violation >>>>>");
        Console.WriteLine("----------------------------------------------------");
        Violation.Bird myBird = new Violation.Sparrow();
        myBird.Fly(); // Works fine, outputs: "Sparrow is flying!"

        try
        {
            myBird = new Violation.Penguin();
            myBird.Fly(); // Throws exception, violating LSP
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine();
        #endregion

        #region Liskov Substitution Principle (LSP) - Fix
        Console.WriteLine("Executing Liskov Substitution Principle (LSP) - Fix >>>>>");
        Console.WriteLine("----------------------------------------------------");
        Fix.IFlyable flyingBird = new Fix.Sparrow();
        flyingBird.Fly(); // Works fine, outputs: "Sparrow is flying!"

        Fix.Bird myBird1 = new Fix.Penguin();
        // Penguin does not have a Fly method, so no LSP violation
        Console.WriteLine();
        #endregion

        #region Interface Segregation (ISP) - Fix
        Console.WriteLine("Interface Segregation Principle (ISP) - Fix >>>>>");
        Console.WriteLine("----------------------------------------------------");
        IWorkable officeWorker = new OfficeWorker();
        IWorkable robot = new Robot();
        IEatable officeWorkerEater = new OfficeWorker();

        officeWorker.Work();
        robot.Work();
        officeWorkerEater.Eat();
        Console.WriteLine();
        #endregion

        #region Dependency Inversion Principle (DIP) - Fix
        Console.WriteLine("Dependency Inversion Principle (DIP) - Fix >>>>>");
        Console.WriteLine("----------------------------------------------------");
        // Dependency injection: choosing a logger implementation at runtime
        ILogger logger = new FileLogger();
        // ILogger logger = new DatabaseLogger();

        Application app = new Application(logger);
        app.DoWork();
        Console.WriteLine();
        #endregion
    }
}