using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_17._02._2022
{
    internal class User
    {
        private string _username;
        public  string UserName
        {             
            set 
            {
                while (_username != value)
                {                    
                    if (value.Length >= 8)
                        _username = value;
                    else
                    {
                        Console.WriteLine("Istifadeci adi minimum 8 simvoldan ibaret olmalidir");
                        Console.WriteLine("Username daxil edin!"); 
                        value = Console.ReadLine();
                    }
                }
            }

        }
        private string _password;
        public string Password
        {
            set
            {
                while (_password != value)
                { int a=0;
                    int b=0;
                        int c=0;

                    
                        foreach (char e in value)
                            if (char.IsDigit(e))
                             a++;
                    foreach (char e in value)
                        if (char.IsUpper(e))
                        b++;
                    foreach (char e in value)
                        if (char.IsLower(e))
                            c++;

                    if (value.Length >= 8 && a > 0 && b > 0 && c > 0)
                    {
                        _password = value;
                        Console.WriteLine("Password ugurla teyin olundu");
                    }
                    else
                    {
                        Console.WriteLine("Password uzunlugu minimum 8 ve min 1 boyuk herf,1 kicik herf ve 1 reqem ozunde eks etmelidir");
                        Console.WriteLine("Password daxil edin!");
                        value = Console.ReadLine();
                    }
                }
            }
        }   
                           
        public User(string name)
        {
            UserName = name;     
        }

    }
}

