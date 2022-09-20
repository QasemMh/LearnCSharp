using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnCSharp
{
    public static class Report
    {
     
 
        public delegate bool IsFitSales(Employee employee);
        public static void GetReport(List<Employee> employees, string title, IsFitSales isFitSales)
        {
            Console.WriteLine(title);
            var filterd = employees.Where(e => isFitSales(e));
            foreach (var employee in filterd)
            {
                Console.WriteLine(employee.Name);
            }
        }
       
    }




}
