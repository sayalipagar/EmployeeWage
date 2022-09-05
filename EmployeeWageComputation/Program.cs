using static EmployeeWageComputation.Employee;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.addCompanEmpyWage("TCS", 10, 7, 150);
            employee.addCompanEmpyWage("Amdocs", 30, 5, 120);
            employee.ComputeEmpWage();
           
        }
    }
}