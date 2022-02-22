using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_22._02._2022
{
    public interface IAccaunt
    {
        public bool PasswordChecker(string sifre);
        public void ShowInfo();
    }
}
