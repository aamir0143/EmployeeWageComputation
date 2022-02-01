// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(dMart.toString());
            Console.WriteLine("======================================================================================");
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.toString());
            Console.WriteLine("======================================================================================");
            Console.ReadLine();
        }
    }
}