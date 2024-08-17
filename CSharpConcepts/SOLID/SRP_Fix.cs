namespace CSharpConcepts.SOLID.Fix
{
    /*
     * Fix: Refactor the code to follow the Single Responsibility Principle by splitting the responsibilities into separate classes.
    */

    // Employee class with only employee-related properties and logic
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public decimal CalculateYearlyBonus()
        {
            return Salary * 0.1M;
        }
    }

    // Separate class for report generation
    public class EmployeeReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
            Console.WriteLine($"Employee: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");
        }
    }
}
