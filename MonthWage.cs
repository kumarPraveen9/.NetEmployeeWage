using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class MonthWage
    {
        public static void Cal_Monthwage()
        {
            Console.WriteLine("Program for Calculating Employee Wage !!");

            int wagePerHour = 20;
            int workingHours = 8;
            int Totalwork = 0;
            int Employeee = 1;
            int atten = EmployeeAttendance.checkatt(Employeee);
            int MonthDays = 30;
            int wageMonth = 0;

            if (atten == 1)
            {
                //Console.WriteLine("\n employee is present");
                Totalwork = wagePerHour * workingHours;
                wageMonth = Totalwork * MonthDays;
                Console.WriteLine("total work in day: " + Totalwork);
                Console.WriteLine("total work in month: " + wageMonth);
            }
            else if (atten == 2)
            {
                Totalwork = wagePerHour * (workingHours / 2);
                wageMonth = Totalwork * MonthDays;
                Console.WriteLine("total Part time work in day: " + Totalwork);
                Console.WriteLine("total Part time work in month: " + wageMonth);
            }
            else
            {
                //Console.WriteLine("\n employee is absent");
                Console.WriteLine("total work : " + Totalwork);
            }
        }
    }
}
