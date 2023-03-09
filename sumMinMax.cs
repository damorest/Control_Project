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
            string[] data = Console.ReadLine().Trim().Split();
            double[] arr = new double[10];

            for(int i = 0; i <= 9; i++)
             {
                 arr[i] = int.Parse(data[i]);
             }
            string result = string.Join(" ", data);


            string newResult = result.Replace(" ", "");
            double fin = Convert.ToInt32(newResult);
            Console.WriteLine(fin + 42);
        }
    }
}
