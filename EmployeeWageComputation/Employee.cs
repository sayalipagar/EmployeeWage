using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Employee
    {

        const int IS_PART_TIME = 1, IS_FULL_TIME = 2, FULL_DAY_HR = 8, PART_DAY_HR = 4;
        int empHrs = 0, totalEmpWage = 0, workingDays = 0;
        public int ComputeEmpWage(string company, int wage_per_hr, int total_working_hrs, int working_day_month)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            while (workingDays < working_day_month && empHrs < total_working_hrs)
            {
                workingDays = workingDays + 1;
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_DAY_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs += PART_DAY_HR;
                        break;

                    default:
                        empHrs += 0;
                        break;
                }
            }
            Console.WriteLine("Working Hours : " + empHrs + ", Working Days : " + workingDays);
            totalEmpWage = empHrs * wage_per_hr;
            Console.WriteLine("Total Employee Wage For " + company + " of " + working_day_month + " Day is : " + totalEmpWage + "\n");
            return totalEmpWage;
        }
    }
}