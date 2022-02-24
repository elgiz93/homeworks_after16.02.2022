using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_23._02._2022.Models
{
    static internal class ExtentionMethods
    {
        static bool IsEven(int eded)
        {
            if (eded % 2 == 0)
            { return true; }
            else
            { return false; }
        }

        static int[] GetValueIndexes(int[] arr,int eded)
        {
            int[] yeniarr =new int[0];
            foreach (char item in arr)
            {
                if (yeniarr[item] == eded)
                { 
                Array.Resize(ref yeniarr, yeniarr.Length+1);
                    yeniarr[yeniarr.Length-1] = eded;
                }
            }
            return yeniarr;
        }
        static bool IsOdd(int eded)
        {
            if (eded%2==1)
            {
                return true;
            }
            else
                return false;
        }
        static bool IsContainsDigit(string str)
        {
            foreach (char item in str)
            { 
                if (char.IsDigit(item)==true)
                {
                    return true;
                }
            }
            return false;
        }
        static int[] GetValueIndexes(string str,char a)
        {
            int[] arr=new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==a)
                {
                    Array.Resize(ref arr,arr.Length+1);
                    arr[arr.Length-1]=i;
                }

            }
            return arr;
        }
    }
}
