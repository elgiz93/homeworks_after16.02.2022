using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_23._02._2022.Models
{
    internal class Student
    {
        public String FullName;
        public String GroupNo;
        public byte Age;

        public Student(string fullname,string groupno,byte age)
        {
            while (!CheckFullname(fullname))
            { Console.WriteLine("FullName duzgun daxil edin"); 
                fullname = Console.ReadLine(); }

                 FullName = fullname;

            while  (!CheckGroupNo(groupno))
            { Console.WriteLine("GroupNo duzgun daxil edin");
                groupno = Console.ReadLine(); }
          
            GroupNo=groupno;

            Age = age;
        }


        static bool CheckGroupNo(string nomre)
        {
            if (nomre.Length == 4 && char.IsUpper(nomre[0]) && char.IsDigit(nomre[1])
                    && char.IsDigit(nomre[2]) && char.IsDigit(nomre[3]))
            { 
                return true;
            }
            else
                return false;

        }

        static bool CheckFullname(string FullName)
        {    
            
            if (FullName.IndexOf(" ")>2 && FullName.IndexOf(" ") < (FullName.Length-2)) ;
            {
                if (FullName.IndexOf(" ", (FullName.IndexOf(" ") + 1)) == -1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
