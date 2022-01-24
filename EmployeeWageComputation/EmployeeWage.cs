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
        int IS_PART_TIME = 2; 
        int EMP_RATE_PER_HOUR = 20;
        //variables
        int empHrs = 0;
        int empWage = 0;
        //Methods
        public void  PartTime() 
        {
            //UC 1: Check Employee Is Present Or Absent.
            //UC 2: Calculate Daily Employee Wage.
            //UC 3: Add Part Time Employee & Wage.
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0,3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Full Time Employee is Present");
                empHrs = 8;
            }
            else if(empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Part Time Employee is Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            //formula for Employee Wage Calculation.
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is : " + empWage);
        }
    }
}
