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
        int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        //variables
        int empHrs = 0;
        int empWage = 0;
        //Methods
        public double DailyEmpWage()
        {
            //UC 1: Check Employee Is Present Or Absent.
            //UC 2: Calculate Daily Employee Wage.
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Employee Wage is : " + empWage);
            return empWage;
        }
    }
}
