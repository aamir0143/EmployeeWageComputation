using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        // Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        //variables
        public static int empHrs = 0;
        public static int totalEmpHrs = 0;
        public static int totalEmpWage = 0;
        public static int totalWorkingDays = 0;
        //Methods
        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)  
        {
            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                //Computation.
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
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company " + company +" is: " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
