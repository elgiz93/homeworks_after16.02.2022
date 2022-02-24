using System;
using Homework_23._02._2022.Models;
using Homework_23._02._2022.Enums;

namespace Homework_23._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("FullName daxil edin");
            //string fullname = Console.ReadLine();
            //Console.WriteLine("GroupNo daxil edin");
            //string groupno = Console.ReadLine();
            //Console.WriteLine("Age daxil edin");
            //byte age = byte.Parse(Console.ReadLine());
            //Student student = new Student(fullname, groupno, age);
            //Console.WriteLine("Student elave edildi!");
            //Console.WriteLine($"{student.FullName},{student.GroupNo},{student.Age}");


            Console.WriteLine("Mehsulun Type ashagidaki siyahidan secib daxil edin");
            foreach (var item in Enum.GetValues(typeof(ProductType)))
            {
                Console.WriteLine($"{(int)item}{item}");
            }
            int daxil=int.Parse(Console.ReadLine());
            string type=Enum.GetName(typeof(ProductType),daxil);
            Console.WriteLine("Mehsulun Qiymetini daxil edin");
            double fiyat=double.Parse(Console.ReadLine());
            Product mehsul=new Product(type,fiyat);
            Console.WriteLine("Mehsul elave edildi");
            mehsul.ShowInfo();



        }
    }
}
