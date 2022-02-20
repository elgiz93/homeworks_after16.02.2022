using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17._02._2022
{
    internal class Employe:Company
    {
        public int No;
        public string FullName;
        public double Salary;

        public Employe(string company,string tamad, double maas):base(company)
        {
            FullName = tamad;
            Salary = maas;     
            CompanyName = company;           
        }
        




    }
}
