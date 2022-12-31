using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class class1111
    {
        public static void Cal_lmtWage()
        {
            Console.WriteLine("Program for Calculating Employee Wage !!");
            
            int workingHours ;
            int Employeee = 1;
            int emphours = 0;
            int days = 1;
            int maxdays = 20;
            int maxhours = 100;
            
            while ((emphours<=maxhours)&&(days<=maxdays))
            {
                   int atten = EmployeeAttendance.checkatt(Employeee);

                    if (atten == 1)
                    {
                        workingHours = 8;
                    }
                    else if (atten == 2)
                    {
                        workingHours = 4;
                    }
                    else
                    {
                    workingHours = 0;
                    }
                emphours+= workingHours;
                if(emphours <= maxhours)
                Console.WriteLine("day::{0} employee_hour::{1}", days, emphours);
                days++;
            }

        }
    }
}


