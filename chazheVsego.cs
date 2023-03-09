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
            Console.WriteLine("Введiть текст: ");
            string text = Console.ReadLine();/*"Я шёл! выносить, мусор и увидел на снегу полбуханки? полбуханки хлеба";*/
            text = text.Replace(":.,;-?!"," ") ;
            string[] arr = text.Split(' ');

            int[] ints = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                ints[i] = Convert.ToInt32(arr[i].Trim().Length);

            }

            Array.Sort(ints);
            Console.WriteLine(string.Join(" ", ints));

            int count = 0;
            int repeat = ints[0];

            for (int j = 0; j < ints.Length; j++)
            {

                if (ints[j] == repeat)
                {
                    count += 1;
                    if (j == ints.Length - 1)
                    { Console.WriteLine($" Довжина : {repeat} по  {count} повторень"); }
                }
                else
                {
                    if (count > 1)
                    { Console.WriteLine($" Довжина : {repeat} по {count} повторень"); }

                    count = 1;

                    repeat = ints[j];
                }

            }
            Console.WriteLine("Введiть кiлькiсть символiв для видалення: ");
            int del = int.Parse(Console.ReadLine());
            string cutText = text;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i].Length == del)
                {
                    cutText = cutText.Replace(arr[i], "");
                    //.WriteLine(cutText);
                }
            }
            cutText = cutText.Replace("  ", " ");
            string newCutText = cutText.Trim();
            newCutText = newCutText.Replace("  ", " ");

            Console.WriteLine(newCutText);

            string[] arrAP = newCutText.Split(' ');

            // Console.WriteLine(arrAP.Length);
            for (int l = 0; l < arrAP.Length; l++)
            {
                //Console.WriteLine(arrAP[l][0].ToString().ToUpper());
                arrAP[l] = $"{arrAP[l][0].ToString().ToUpper()}{arrAP[l].Substring(1)}";
            }
            string dataToShow = string.Join(" ", arrAP);
          
            Console.WriteLine(dataToShow);
        }
    }
    
}
