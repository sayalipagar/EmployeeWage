using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Employee
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        private int numOfCompany = 0;

        private CompanyEmpWage[] companyEmpWagesArray;
        public Employee()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[4];
        }
        public void addCompanEmpyWage(string company, int empRatePerHr, int noOfWorkingDays, int maxHrPerMonth)
        {
            companyEmpWagesArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHr, noOfWorkingDays, maxHrPerMonth);
            numOfCompany++;

        }
        public void ComputeEmpWage()
        {

            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWagesArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWagesArray[i]));
                Console.WriteLine(this.companyEmpWagesArray[i].toString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHrPerMonth && totalWorkingDays < companyEmpWage.NoOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "EmpHr:" + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }

        }
    }



           
            
          