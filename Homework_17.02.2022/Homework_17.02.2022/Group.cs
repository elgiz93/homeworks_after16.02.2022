using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17._02._2022
{
    internal class Group
    {
        public string No;
        public int Limit;
        public Student[] Students;
        public void AddStudent(string adi, string soyadi)
        {
            
            if (Students.Length <= Limit)               
            {
                Student telebe = new Student(adi, soyadi);
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length-1] = telebe;  
            }
            else
                Console.WriteLine("Group-da max telebe sayina catmisiniz!");
        }
        public void GetStudent()
        {
            foreach (Student item in Students)
            {
                Console .WriteLine($"Telebenin adi:{item.Name}, Telebenin soyadi:{item.Surname}");
            }
        }







    }
}
