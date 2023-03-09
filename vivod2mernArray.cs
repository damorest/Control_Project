using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int[,] InputArray(int n, int m)
        {
            int[,] a = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                string[] arrString = Console.ReadLine().Trim().Split();
                for(int j = 0; j < m; j++)
                {
                    a[i,j] = int.Parse(arrString[j]);
                }
            } return a;
        }
        static void Main(string[] args)
        {
            InputArray();
           /* string[] razm = Console.ReadLine().Trim().Split();
            int n = int.Parse(razm[0]);
            int m = int.Parse(razm[1]);
            

            string[] data = Console.ReadLine().Trim().Split();
            int[,] arr = new int[n,m];

            for (int i = 0; i < data.Length; i++)
            {
                

                for (int k = 0; k < n; k++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[k, j] = int.Parse(data[i]);
                        i++;

                        Console.Write($"{arr[k, j]} ");
                    }
                    Console.WriteLine();
                }*/
               

        }
    }
}
