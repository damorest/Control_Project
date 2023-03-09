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
            
            int x = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Trim().Split();
            int p = int.Parse(data[0]);
            int q = int.Parse(data[1]);
            int r = int.Parse(data[2]);
            long sum = 0;

            long[] arr = new long[20];

            arr[0] = x;

            for (int i = 1; i <= 19; i++)
            {
                arr[i] = arr[i - 1] * ((i + 1) - 10) + x;

            }
            long arrP = arr[p - 1];
            long arrQ = arr[q - 1];
            long arrR = arr[r - 1];
                //Console.WriteLine(sum);
            
            //string result = string.Join(" ", arr);

            //Console.WriteLine(result);
            Console.WriteLine(arrP + arrQ + arrR);
            //Console.WriteLine($"{arr[p]} {arr[q]} {arr[r]}");
        }
    }
}
