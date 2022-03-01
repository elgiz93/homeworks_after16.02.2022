using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Interfaces;
using ConsoleAppProject.Models;

namespace ConsoleAppProject.Services
{
    internal class HumanResourceManager : IHumanResourceManager
    {

        private Department[] _departments;
        public Department[] Departments { get { return _departments; } }

        public HumanResourceManager()
        {
            _departments = new Department[0];
        }

        public void AddDepartment(string name, int workerlimit, double salarylimit)
        {
            Array.Resize(ref _departments, _departments.Length + 1);

            _departments[_departments.Length-1]=new Department(name,workerlimit,salarylimit);
        }

        public void AddEmployee(string fullname, string position, double salary, string departamentname)
        {
            foreach (Department item in _departments)
            {
                if (item.Name == departamentname.Trim().ToUpper())
                {
                    Array.Resize(ref item.Employees, item.Employees.Length + 1);
                    item.Employees[item.Employees.Length - 1] = new Employee(fullname, position, salary, item.Name);
                    return;
                }
            }
            Console.WriteLine("Daxil edilmish adda Department yoxdur duzgun daxil edin!");

        }

        public void EditDepartments(string olddepartment, string newdepartment)
        {
            foreach(Department item in _departments)
            {
                while (item.Name == newdepartment.Trim().ToUpper())
                {
                    Console.WriteLine("Yeni vermek istediyiniz adda Department artiq movcuddur! Basqa ad secin");
                    newdepartment = Console.ReadLine();
                }
            }
            foreach (Department item in _departments)
            {
                if (item.Name == olddepartment.Trim().ToUpper())
                {
                    item.Name = newdepartment.Trim().ToUpper();
                    return;
                }
            }
            Console.WriteLine("Daxil edilmish adda Department yoxdur! Duzgun daxil edin!");
        }

        public void EditEmployee(string no, string fullname, string position, double salary)
        {
            foreach (Department item in _departments)
            {
                foreach (Employee employee in item.Employees)
                {
                    if (employee.No == no.Trim().ToUpper())
                    {
                        employee.Salary = salary;
                        employee.Position = position.Trim().ToUpper();
                        employee.FullName = fullname.Trim().ToUpper();
                        return;
                    }
                }
            }
            Console.WriteLine("Daxil edilmish adda hec bir Departmentde Employee yoxdur duzgun daxil edin!");
        }

        public void GetDepartments()
        {
            Console.WriteLine("Butun Departmentler siyahisi:");
            foreach (Department item in _departments)
            {
                Console.WriteLine(item);
            }
        }

        public void RemoveEmployee(string no, string departamentname)
        {
            foreach (Department department in _departments)
            {
              if (department.Name == departamentname.Trim().ToUpper())
              {
                for (int i = 0; i < department.Employees.Length; i++)
                {
                  if (department.Employees[i].No == no.Trim().ToUpper())
                  {
                   department.Employees[i] = department.Employees[department.Employees.Length - 1];
                   Array.Resize(ref department.Employees, department.Employees.Length - 1);
                   return;
                  }
                  else
                        {
                            Console.WriteLine("Daxil edilen departamentde bu adda ishci yoxdur!");
                            return;
                        }
                }
              }  
              
            }
            Console.WriteLine("Daxil edilmish adda hec bir Department yoxdur duzgun daxil edin!");
        }
    }
}
