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
                        

            int[] arr = new int[n];
            int minSum = 0;            
            int maxSum = 0;



            for (int i = 0; i < data.Length; i++)
            {
                arr[i] = int.Parse(data[i]);
                int maxValue = arr[0];
                int minValue = arr[0];

                int sum = 0;

                while (arr[i] / 10 >= 0)
                {
                    sum = sum + arr[i] % 10;
                    arr[i] /= 10;
                    if (arr[i] / 10 == 0)
                    {
                        sum = sum + arr[i] % 10;
                        break;
                    }
                }
                // Console.WriteLine($"sum {i} = {sum}");

               
                if (sum > maxSum)
                {
                    maxSum = sum;
                   // maxValue = arr[i];
                }
                else if (sum < minSum)
                {
                    minSum = sum;
                   // minValue = i;
                }

                //Console.WriteLine($"max  {maxSum}");
            }
            
            //Console.WriteLine($"max  {maxIndex}");
            //string result = string.Join(" ", arr);

            //Console.WriteLine(result);
            Console.WriteLine(minSum);
            Console.WriteLine(maxSum);
            

        }
    }
}
