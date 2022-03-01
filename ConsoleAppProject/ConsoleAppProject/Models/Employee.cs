using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.Models
{
    internal class Employee
    {

        public string No { get; }
        public string FullName;
        public string Position;
        public double Salary;
        public string DepartamentName;
        private int _count =1000;

        public Employee(string fullname,string position,double salary,string departamentname)
        {
            No = $"{char.ToUpper(departamentname[0])}{char.ToUpper(departamentname[1])}{++_count}";
            FullName = fullname.Trim().ToUpper();
            Position = position.Trim().ToUpper(); 
            Salary = salary;
            DepartamentName = departamentname.Trim().ToUpper();

        }
        public override string ToString()
        {
            return $"Nomresi:{No} /Adi:{FullName} /Vezifesi:{Position} /Maasi:{Salary} /Department:{DepartamentName}";
        }




    }
}
