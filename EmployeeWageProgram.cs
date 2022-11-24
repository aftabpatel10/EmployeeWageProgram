using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class EmployeeWageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Conmputation");
            const int EMP_RATE_PER_HR = 20;
            int empWage = 0;
            int empHrs = 0;
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            Random r = new Random();
            int employeeInput = r.Next(0, 3);
            if (employeeInput == IS_PART_TIME)
            {
                Console.WriteLine("Employee is Part time Present");
                empHrs = 4;
            }
            else if (employeeInput == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Daily Employee Wage is:" + empWage);
            Console.ReadLine();
        }
    }
}
