namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ComputeEmpWage("Dmart", 20, 100, 20);
            emp.ComputeEmpWage("Amdocs", 21, 150, 20);
            emp.ComputeEmpWage("Infosys", 19, 120, 21);
        }
    }
}