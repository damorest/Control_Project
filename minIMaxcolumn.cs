using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static int[,] InputArray(int n, int m)
        {
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] arrString = Console.ReadLine().Trim().Split();
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(arrString[j]);
                }
            }
            return a;
        }
        static void MaxColumn(int[,] arrN)
        {
            int indexMin = 0; int min = arrN[0, 0];
            
            for (int i = 0; i < arrN.GetLength(0); i++)
            {
                for (int j = 0; j < arrN.GetLength(1); j++)
                {
                    int k = arrN.GetLength(1);
                    if (j < k)
                    {
                        if (arrN[i, j] <= min)
                        {
                            indexMin = i; min = arrN[i, j];
                            
                        }
                        Console.WriteLine(min);
                    }
                    else if (j == k)
                    {
                       // Console.WriteLine(min);
                        
                    }


                        //Console.Write($"{min} ");

                }
                
                //Console.Write($"{min} ");

            }
            //Console.Write($"{min} ");
        }

        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Trim().Split();
            int[,] arrB = InputArray(int.Parse(input[0]), int.Parse(input[1]));
            MaxColumn(arrB);


        }
    }
    }
