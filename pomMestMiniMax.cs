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
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

           // string[] data = Console.ReadLine().Trim().Split();
            int[,] arr = new int[n,m];

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Trim().Split();

                for (int j = 0; j < m; j++)
                {
                    arr[i,j] = int.Parse(data[j]);

                    Console.Write(arr[i,j]);
                }
                //Console.Write(String.Format("{0,3}", arr[i, j]));

                //Console.WriteLine(result);

            }//string result = string.Join("", arr);
            //Console.WriteLine(result);




        }
    }
}
