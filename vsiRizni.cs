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
            int min = 0;
            int max = 0;
            

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Trim().Split();
                int[] arr = new int[data.Length];

                for (int j = 0; j < arr.Length; j++)
                {

                    arr[j] = int.Parse(data[j]);

                    while (arr[j] / 10 != 0)
                    {
                        int sum = 0;
                        sum = sum + (arr[j] % 10);
                        arr[j] /= 10;
                       /* if (arr[j] / 10 == 0)
                        {
                            sum = sum + arr[j] % 10;
                        }*/
                        Console.WriteLine(sum);
                       
                    }
                }

                                
                   

                
            

            }
        }
    }
}
