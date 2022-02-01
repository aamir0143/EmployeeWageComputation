// See https://aka.ms/new-console-template for more information
using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Employee Wage Problems============");
            EmployeeWage dMart = new EmployeeWage("DMart", 20, 10, 100);
            EmployeeWage reliance = new EmployeeWage("Reliance", 10, 20, 100);
            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.ToString());
            Console.ReadLine();
        }
    }
}