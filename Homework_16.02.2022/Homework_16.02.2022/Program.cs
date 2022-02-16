using System;

namespace Homework_16._02._2022
{
    internal class Program
    {
        #region task1
        //static void Main(string[] args)
        //{            
        //    int[] b = { 43, 23, 19, 14, 11 };
        //    Customsort(b);
        //    for (int i = 0; i < b.Length; i++)
        //        Console.WriteLine(b[i]);
        //}


        //static void Customsort(int[] array)
        //{
        //    int a = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = 0; j < array.Length-1; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                a = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = a;
        //            }
        //        }
        //    }
        //}
        #endregion
        #region task2
        static void Main(string[] args)
        {
            string[] arr = {"salam","gozel","ureyi","temiz","insanlar"};
            Console.WriteLine("Herf daxil edin");
            char herf = char.Parse(Console.ReadLine());
            Charfinder(arr, herf);
        }
        static void Charfinder(string[] array, char a)
        {
            string b="0";
            for (int i = 0; i < array.Length; i++)
            {
                b = array[i];
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] == a)
                        Console.WriteLine(b);
                }
            }
            return;
        }



        #endregion
    }
}
