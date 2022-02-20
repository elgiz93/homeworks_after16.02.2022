using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17._02._2022
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public double TotalIncome;


        public void Sell()
        {
            if (Count>0)
            {
                Count--;
                    TotalIncome = +Price;
                Console.WriteLine("Satis ugurla tamamlandi") ;
            }
            else
                Console.WriteLine("Stockda kifayet geder mehsul yoxdur");
        }
        public void AllInfo()
        {
           Console.WriteLine($"Adi:{Name} Qiymeti:{Price} Sayi:{Count} Geliri:{TotalIncome}");
        }
        public Product(string adi)
        {
            Name= adi;
        }
    }
}
