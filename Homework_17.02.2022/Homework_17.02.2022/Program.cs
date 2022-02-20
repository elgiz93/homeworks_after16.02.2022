using System;

namespace Homework_17._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Istediyiniz task nomresini qeyd edin 1-5");
            byte a = byte.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Zehmet olmasa Username daxil edin");
                User user1 = new User(Console.ReadLine());
                Console.WriteLine("Zehmet olmasa Password daxil edin");
                user1.Password = Console.ReadLine();
            }

            else if (a == 2)
            {
                Console.WriteLine("Zehmet olmasa Mehsul elave edin");
                Product mal1 = new Product(Console.ReadLine());
                Console.WriteLine("Zehmet olmasa Mehsulun qiymetini daxil edin");
                mal1.Price = double.Parse(Console.ReadLine());
                Console.WriteLine("Zehmet olmasa Mehsulun sayini daxil edin");
                mal1.Count = int.Parse(Console.ReadLine());
                mal1.AllInfo();
                Console.WriteLine("Mehsul satmaq ucun y duymesini klikleyin");
                string y = Console.ReadLine();
                if (y == "y")
                {
                    mal1.Sell();
                }
                mal1.AllInfo();
            }

            else if (a == 3)
            {
                Console.WriteLine("10 eded kitab yaradacaqsiniz");
                Book[] books = new Book[10];
                for (int i = 0; i < books.Length; i++)
                {
                    string x = "a";
                    int y = 0;
                    while (x.Length < 3)
                    {
                        Console.WriteLine($"{i + 1} Kitabin adini daxil edin");
                        x = Console.ReadLine();
                    }
                    while (y < 10)
                    {
                        Console.WriteLine($"{i + 1} Kitabin sehifelerinin sayini daxil edin");
                        y = int.Parse(Console.ReadLine());
                    }
                    Book kitab = new Book(x, y);
                    books[i] = kitab;
                }
                Console.WriteLine("Butun kitablar elave edildi");
                foreach (Book item in books)
                {
                    item.FullInfo();
                }

            }

            else if (a == 4)
            {

                string input = "a";
                Group Group1 = new Group();
                Group1.No = "P129";
                Group1.Limit = 2;
                Group1.Students = new Student[0];
                Console.WriteLine("Telebeleri daxil edin");
                do
                {
                    Console.WriteLine("Adi:");
                    string ad = Console.ReadLine();
                    Console.WriteLine("Soyadi");
                    string soyad = Console.ReadLine();
                    Group1.AddStudent(ad, soyad);
                    Console.WriteLine("Yeni telebe elave etmek isteyirsiniz? y/n");
                    input = Console.ReadLine();
                }
                while (input == "y");
                Console.WriteLine("P129 butun telebeleri");
                Group1.GetStudent();


            }

            else if (a == 5)
            {
                string input = "a";
                Console.WriteLine("Sirketin adini qeyd edin");
                string sirketinadi= Console.ReadLine(); 
                Company sirket = new Company(sirketinadi);
                Console.WriteLine("Sirketin Limitini qeyd edin");
                int limiti = int.Parse(Console.ReadLine());
                sirket.Limit = limiti;
                Console.WriteLine("Sirkete ishciler elave edeceksiniz");
                int p = 0;
                do
                {
                    Console.WriteLine("Ishcinin tam adini qeyd edin");
                    string tamad = Console.ReadLine();
                    Console.WriteLine("Maashi qeyd edin");
                    double maas = double.Parse(Console.ReadLine()); 
                    sirket.AddEmploye(sirketinadi, tamad, maas);
                    Console.WriteLine("Yeni telebe elave etmek isteyirsiniz? y/n");
                    input = Console.ReadLine();
                    p++;
                }
                while (input == "y" && p<sirket.Limit);
                Console.WriteLine("Company-nin butun ishcileri");
                sirket.GetEmploye();
                Console.WriteLine("hansi nomreli ishcini silmek isteyirsiz?");
                int nomre = int.Parse(Console.ReadLine());
                sirket.RemoveEmploye(nomre);
                Console.WriteLine("Company-nin butun ishcileri");
                sirket.GetEmploye();








            }
        }
    }
}

             
    