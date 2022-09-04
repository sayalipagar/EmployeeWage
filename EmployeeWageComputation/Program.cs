using static EmployeeWageComputation.Employee;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee dMRT = new Employee("DMART", 20, 2, 10);
            Employee reliance = new Employee("RELIANCE", 10, 4, 20);
            dMRT.ComputeEmpWage();
            Console.WriteLine(dMRT.toString());
            reliance.ComputeEmpWage();
           Console.WriteLine(reliance.toString());
        }
    }
}