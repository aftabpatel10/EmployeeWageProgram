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
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            Random r = new Random();
            int employeeInput = r.Next(0, 3);
            switch (employeeInput)
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
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Daily Employee Wage is:" + empWage);
            Console.ReadLine();
        }
    }
}
