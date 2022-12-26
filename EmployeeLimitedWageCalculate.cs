using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeLimitedWageCalculate
    {
        public static void Cal_limitedwage()
        {
            Console.WriteLine("Program for Calculating Employee Wage !!");

            int wagePerHour = 20;
            int workingHours = 8;
            int workinglimitedHours = 0;
            int Totalwork = 0;
            int Employeee = 1;
            int atten = EmployeeAttendance.checkatt(Employeee);
            int days = 1;
            int flag = 0;
            while ((days <= 20) && (workinglimitedHours <= 100))
            {
                if (atten == 1)
                {

                    Totalwork = wagePerHour * workingHours;
                    workinglimitedHours = workinglimitedHours + 8;
                    
                   
                    if ((workinglimitedHours <= 100) && (days <= 20))
                    {
                        flag = 1;
                          
                        
                    }
                }
                else if (atten == 2)
                {
                    Totalwork = wagePerHour * (workingHours / 2);
                    workinglimitedHours = workinglimitedHours + 4;
                    
                    if ((workinglimitedHours <= 100) && (days <= 20))
                    {
                        flag = 2;
                        
                    }
                }
                else
                {
                    Console.WriteLine("working hours : " + workinglimitedHours);
                    Console.WriteLine("the number of day are :" + (days - 1));
                    break;
                }
                days = days + 1;
            }
                if ((flag==2))
                {
                    Console.WriteLine("working hours : " + workinglimitedHours);
                    Console.WriteLine("the number of day are :" + (days-1));
                }
                if ((flag==1))
                {
                    Console.WriteLine("working hours : " + (workinglimitedHours-8));
                    Console.WriteLine("the number of day are :" + (days-2));
                }
            
        }
    }
}
