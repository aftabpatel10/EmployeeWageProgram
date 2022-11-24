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
            const int EMP_RATE_PER_HR = 20;
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int NO_OF_WORKING_DAYS = 2;
            const int MAX_HRS_OF_MONTH = 10;
            int totalEmpHrs = 0;
            int empHrs = 0;
            int totalWorkingDays = 0;
            while (totalWorkingDays <= NO_OF_WORKING_DAYS && totalEmpHrs <= MAX_HRS_OF_MONTH)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs:" + totalEmpHrs);
                Console.ReadLine();
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total emp Wage is:" + totalEmpWage);
        }
    }
}
