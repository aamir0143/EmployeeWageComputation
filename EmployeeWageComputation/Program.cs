﻿// See https://aka.ms/new-console-template for more information
using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Employee Wage Problems============");
            EmployeeWage employeeWage = new EmployeeWage();
            EmployeeWage.ComputeEmpWage();//Call the Method.
            Console.ReadLine();
        }
    }
}