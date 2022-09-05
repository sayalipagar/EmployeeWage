using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class CompanyEmpWage
    {
        public string company;
        public int empRatePerHr;
        public int NoOfWorkingDays;
        public int maxHrPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHr, int noOfWorkingDays, int maxHrPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            NoOfWorkingDays = noOfWorkingDays;
            this.maxHrPerMonth = maxHrPerMonth;
            
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage=totalEmpWage;
        }
        public string toString()
        {
            return "Total Wage For Company" + this.company + "is: " + this.totalEmpWage;
        }
    }
}
