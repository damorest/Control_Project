using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Trim().Split();
            int indexMax = 0;
            int indexMin = 0;
            

            int[] arr = new int[n];
            int sum = 0;
            int min = arr[0]; int max = arr[0];

            for (int i = 0; i < data.Length; i++)
            {
                arr[i] = int.Parse(data[i]);
                
                sum = sum + arr[i];

                if (arr[i] >= max)
                {
                    max = arr[i];
                    indexMax = i;
                }else if (arr[i] < min) 
                {
                min = arr[i];
                    indexMin = i;

                }
            }


            //string result = string.Join(" ", arr);

            //Console.WriteLine(result);
            Console.WriteLine(sum);
            Console.WriteLine($"{max} {indexMax + 1}");
            Console.WriteLine($"{min} {indexMin + 1}");
        }
    }
}
