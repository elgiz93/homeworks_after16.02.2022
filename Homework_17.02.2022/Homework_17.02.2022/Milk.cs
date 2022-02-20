using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17._02._2022
{
    internal class Milk:Product
    {
        public double Volume;
        public double Fat;


        public Milk(string adi):base(adi)
        {
            Name = adi;
        }
    }
}
