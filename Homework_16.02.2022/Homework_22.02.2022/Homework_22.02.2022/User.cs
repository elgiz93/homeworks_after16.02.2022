using System;
using System.Collections.Generic;
using System.Text;


namespace Homework_22._02._2022
{
    internal class User : IAccaunt

    {

        public string Fullname { get; set; }
        public string Email { get; set; }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
             if(IAccount.PasswordChecker(Password)==true)
                {
                    _password = Password;
                }
             else Password=Console.ReadLine();

            }
        }
        public User(string email,string password)
        {
            Email = email; 
            Password = password;
        } 

        bool IAccaunt.PasswordChecker(string sifre)
        {
            {
                int upper = 0;
                int lower = 0;
                int digit = 0;

                if (sifre.Length >= 8)
                {
                    foreach (char item in sifre)
                    {
                        if (char.IsUpper(item))
                        {
                            upper++;
                        }
                        if (char.IsLower(item))
                        {
                            lower++;
                        }
                        if (char.IsDigit(item))
                        {
                            digit++;
                        }
                    }
                    if (upper > 0 && lower > 0 && digit > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }

                else
                    return false;
          }
        }
         void IAccaunt.ShowInfo()
        {
            Console.WriteLine($"Email:{Email}\n Password:{Password}");
        }
    }
}

       
