using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17._02._2022
{
    internal class Company
    {
        public string CompanyName;
        public int Limit;
        public Employe[] Employees;
        

        public Company(string company)
        {
            CompanyName=company;
            Limit=4;
            Employees=new Employe[0];
        }
        public void AddEmploye(string company,string tamad,double maas)
        {
            if (Employees.Length <= Limit)
            {
                Employe ishci = new Employe(company,tamad,maas);
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = ishci;
                ishci.No = Employees.Length;
            }
            else
                Console.WriteLine("Company-de max Ishci sayina catmisiniz!");
        }
        public void GetEmploye()
        {
            foreach (Employe item in Employees)
            {
                Console.WriteLine($"Ishcinin adi:{item.FullName}, Ishcinin No:{item.No}");
            }
        }
        public string SearchEmployees(string ishcinintamadi)
        {
            string cavab="islemedi";
            foreach (Employe item in Employees)
            {
                if (item.FullName == ishcinintamadi)
                { 
                    cavab = $"{item.No}Bu ad ile employe var";
                }
            
                
                else
                {
                   cavab  ="Bu adda ishci yoxdur";
                }
            }
            return cavab;
        }
        public void RemoveEmploye(int nomre)
        {
            Employees[nomre - 1] = null;
            for (int i = nomre; i < Employees.Length; i++)
            {
                Employees[nomre - 1] = Employees[nomre];
            }
            Array.Resize(ref Employees, Employees.Length - 1);
        }
    }
}
