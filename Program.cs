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
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Trim().Split();
                int[] arr = new int[data.Length];

                for (int j = 0; j < arr.Length; j++)
                {

                    arr[j] = int.Parse(data[j]);

                }
                Array.Sort(arr);

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] != arr[j + 1])
                    {

                        count++;

                    }


                }
                Console.WriteLine(count + 1);

            }
        }
    }
}
