using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17._02._2022
{
    internal class Book
    {
        public string Name;
        public int PageCount;
        public void FullInfo()
        {
            Console.WriteLine($"Kitabin adi:{Name} Sehife sayi:{PageCount}");
        }
        public Book(string name,int pageCount)
        {
            if (name.Length >= 3 && pageCount >= 10)
            {
                Name = name;
                PageCount = pageCount;
            }
            else
                Console.WriteLine("PageCount 10-dan az, Name deyerinin uzunlugu 3-den qisa ola bilmez");
        }
    }
}
