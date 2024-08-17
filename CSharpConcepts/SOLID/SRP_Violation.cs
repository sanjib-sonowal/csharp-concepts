namespace CSharpConcepts.SOLID.Violation
{
    /*
     * Problems:
     * The Employee class is handling two responsibilities:
     * Business logic (calculating the yearly bonus).
     * Reporting (generating a report of the employee's details).
     * 
     * This violates the Single Responsibility Principle because changes in the reporting requirements would 
     * force us to modify the Employee class, even though the business logic for employees hasn’t changed.
    */

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        // Method for calculating the yearly bonus
        public decimal CalculateYearlyBonus()
        {
            return Salary * 0.1M;
        }

        // Method for generating a report
        public void GenerateReport()
        {
            Console.WriteLine($"Employee: {Name}, Position: {Position}, Salary: {Salary}");
        }
    }

}
