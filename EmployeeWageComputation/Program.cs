// See https://aka.ms/new-console-template for more information
using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Employee Wage Problems============");
            EmployeeWage employeeWage = new EmployeeWage();
            EmployeeWage.ComputeEmpWage("DMart", 20, 10, 100);//Call the Method.
            EmployeeWage.ComputeEmpWage("Relince", 10, 20, 100);
            EmployeeWage.ComputeEmpWage("Flipkart", 15, 24, 100);
            Console.ReadLine();
        }
    }
}