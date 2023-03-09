using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int n = 8;
            string text = "BBBCCCBC";
            char[] arr = text.ToCharArray();


            int[] ints = new int[arr.Length];

             for (int i = 0; i < arr.Length; i++)
             {
                 ints[i] = Convert.ToInt32(arr[i]);

             }

             Array.Sort(ints);
             // Console.WriteLine(string.Join(" ", ints));

             int count = 0;
             int repeat = ints[0];
             int max = 0;
             int max1 = max;
             int max2 = 0;

             for (int j = 0; j < ints.Length; j++)
             {

                 if (ints[j] == repeat)
                 {
                     count++;
                   // max1 = count;
                   /* if (j == ints.Length - 1)
                         
                     { Console.WriteLine($"{repeat}"); }*/
                 }
                 else
                 {
                    max1 = count;
                    if (max < max1) { max = max1; }
                     Console.WriteLine($"{repeat}");
                     count = 1;

                     repeat = ints[j];
                 }



             }
        }
    }
    
}
