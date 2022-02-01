using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation 
{
    public class EmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHrsInMonth;
        private int totalEmpWage;

        public EmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }

        public void ComputeEmpWage ()  
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation.
            while (totalEmpHrs <= this.maxHrsInMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
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
                        empHrs = 0;
                        break;
                }
                totalEmpHrs+= empHrs;
                Console.WriteLine("Day#:"+ totalWorkingDays +  " Emp Hrs: " + empHrs);
            }
            //formula for Employee Wage Calculation.
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
        }
        public string toString()  
        {
            return "The Total Emp Wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
