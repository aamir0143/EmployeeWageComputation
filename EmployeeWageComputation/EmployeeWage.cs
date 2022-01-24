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
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        //variables
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;
        //Methods
        public void  MonthlyWage()  
        {
            //UC 1: Check Employee Is Present Or Absent.
            //UC 2: Calculate Daily Employee Wage.
            //UC 3: Add Part Time Employee & Wage.
            //UC 4: Solving Using Switch Case Statement.
            //UC 5: Calculating Wages for a Month.
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0,3);
            //if (empCheck == IS_FULL_TIME)
            //{
            //    Console.WriteLine("Full Time Employee is Present");
            //    empHrs = 8;
            //}
            //else if(empCheck == IS_PART_TIME)
            //{
            //    Console.WriteLine("Part Time Employee is Present");
            //    empHrs = 4;
            //}
            //else
            //{
            //    Console.WriteLine("Employee is Absent");
            //    empHrs = 0;
            //}

            for(int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
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
                //formula for Employee Wage Calculation.
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Employee Wage is : " + empWage);
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total Emp Wage is : " + totalEmpWage);
          
        }
    }
}
