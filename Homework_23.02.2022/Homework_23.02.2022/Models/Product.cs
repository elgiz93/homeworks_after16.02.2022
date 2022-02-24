using System;
using System.Collections.Generic;
using System.Text;


namespace Homework_23._02._2022.Models
{
    internal class Product
    {
        static int Startcode = 1000;
        public string Code;
        public string Name;
        private double Price;
        public double DiscountedPrice;
        public string ProductType;
        public int TotalCount;

        public void ShowInfo()
        {
            Console.WriteLine($"{Code} {Price} {DiscountedPrice} {ProductType}");
        }

        


        public Product(string type, double deyeri)
        {
            ProductType = type;
            Price = deyeri;
            Code = $"{type[0]}{++Startcode}";
            if (type == "Bakery")
            {
                DiscountedPrice = Price * 0.9;
            }
        }
    }
}
