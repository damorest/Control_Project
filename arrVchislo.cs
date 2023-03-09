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
            double count = 0;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {

                string[] data = Console.ReadLine().Trim().Split();
                int[] arr = new int[n];

                for (int j = 0; j < data.Length; j++)
                {
                    arr[j] = int.Parse(data[j]);

                }
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] % 2 != 0 && (j + 1) % 2 == 0)
                    {
                        sum += arr[j];
                        count++;

                    }


                }
                Console.WriteLine(sum / count);

            }
            
        }
    }
}
