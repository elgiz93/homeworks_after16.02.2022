using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17._02._2022
{
    internal class Student
    {
        private string _name;
        public string Name { get { return _name; } }
        private string _surname;
        public string Surname { get { return _surname; } }

        public Student(string adi, string soyadi)
        {
            _name= adi;   
                _surname= soyadi; 
        }
    }
}
