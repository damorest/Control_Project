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
            int[] arr = new int[10];

            arr[0] = x;

            for (int i = 1; i <= 9; i++)
            {
                arr[i] = arr[i - 1] * (arr[i - 1]) % 100 - 5 * arr[i - 1] + 6;
            }


            string result = string.Join(" ", arr);

            Console.WriteLine(result);
        }
    }
}
