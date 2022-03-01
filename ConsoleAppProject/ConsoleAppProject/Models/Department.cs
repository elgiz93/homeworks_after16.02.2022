using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.Models
{
    internal class Department
    {
        public string Name;
        public int WorkerLimit;
        public double SalaryLimit;
        public Employee[] Employees;

        public Department(string name,int workerlimit,double salarylimit)
        {
            Employee[] Employees=new Employee[0];
            Name = name.Trim().ToUpper();
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
        }
        public double CalcSalaryAverage()
        {
            double sum = 0;
            foreach (Employee item in Employees)
            {
                sum += item.Salary;
            }
            return (sum/ Employees.Length);
        }

        public override string ToString()
        {
            return $"Name:{Name} /Limit:{WorkerLimit} /Max Salary for all:{SalaryLimit}";
        }


    }
}