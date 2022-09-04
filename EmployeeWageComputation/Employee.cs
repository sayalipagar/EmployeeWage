using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Employee
    {
            const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
            private string company;
            private int empRatePerHr;
            private int NoOfWorkingDays;
            private int maxHrPerMonth;
            private int totalEmpWage;

            public Employee(string company, int empRatePerHr, int NoOfWorkingDays, int maxHrPerMonth)
            {
                this.company = company;
                this.empRatePerHr = empRatePerHr;
                this.NoOfWorkingDays = NoOfWorkingDays;
                this.maxHrPerMonth = maxHrPerMonth;
            }
           public void ComputeEmpWage()
            {
                int empHrs = 0, totalEmpHr = 0, totalWorkingdays = 0;

                while (totalEmpHr <= this.maxHrPerMonth && totalWorkingdays < this.NoOfWorkingDays)
                {
                    totalWorkingdays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                            empHrs = 4;
                            break;
                     
                        default:
                            empHrs += 0;
                            break;
                    }
                }
                totalEmpHr = empHrs;
                Console.WriteLine("Day: " + totalWorkingdays + "Emp Hr: " + empHrs);

                totalEmpWage = totalEmpHr * this.empRatePerHr;
             
            }
              public string toString()
            {
                return "total Emp Wage For Company: " + this.company + "is:" + this.totalEmpWage;

            }
        }
    

}