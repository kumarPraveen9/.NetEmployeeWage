﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeAttendance
    {
        public static void checkatt()
        {
            Console.WriteLine("Program for checking Employee Present or not!!");
            int Employee =1;
            Random random=new Random();
            int check=random.Next(2);
            if (Employee == check)
            {
                Console.WriteLine("\n employee is present");
            }
            else
            {
                Console.WriteLine("\n employee is absent");
            }
        }
    }
}
