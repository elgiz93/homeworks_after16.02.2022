using System;
using Homework_23._02._2022.Models;

namespace Homework_23._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FullName daxil edin");
            string fullname = Console.ReadLine();
            Console.WriteLine("GroupNo daxil edin");
            string groupno = Console.ReadLine();
            Console.WriteLine("Age daxil edin");
            byte age = byte.Parse(Console.ReadLine());
            Student student = new Student(fullname, groupno, age);
            Console.WriteLine("Student elave edildi!");
            Console.WriteLine($"{student.FullName},{student.GroupNo},{student.Age}");
        }
    }
}
