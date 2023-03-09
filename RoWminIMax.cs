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
       
            static void PrintArray(int[,] arrN)
            {
                for (int i = 0; i < arrN.GetLength(0); i++)
                {
                    for (int j = 0; j < arrN.GetLength(1); j++)
                    {
                        Console.Write($"{arrN[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
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
        static int MaxColumn(int[,] arrN)
        {
            int indexMax = 0; int max = arrN[0, 0];
            for(int i = 0;i < arrN.GetLength(0);i++)
            {
                for(int j = 0;j < arrN.GetLength(1);j++)
                {
                    if (arrN[i, j] >= max)
                    {
                        indexMax = i; max = arrN[i, j];
                    }
                }
                
            }return indexMax;
        }
        static int MinColumn(int[,] arrN)
        {
            int indexMin = 0; int min = arrN[0, 0];
            for (int i = 0; i < arrN.GetLength(0); i++)
            {
                for (int j = 0; j < arrN.GetLength(1); j++)
                {
                    if (arrN[i, j] < min)
                    {
                        indexMin = i; min = arrN[i, j];
                    }
                }

            }
            return indexMin;
        }
        static int[,] ChangeColumns(int[,] arrN,int k1,int k2)
        {
            int[,] arrP = arrN;
            for(int i = 0; i < arrP.GetLength(0); i++)
            {
                int temp = arrP[i, k1];
                arrP[i, k1] = arrP[i, k2];
                arrP[i, k2] = temp;
            }
            return arrP;
        }

            static void Main(string[] args)
            {

                string[] input = Console.ReadLine().Trim().Split();
                int[,] arrB = InputArray(int.Parse(input[0]), int.Parse(input[1]));
                 arrB = ChangeColumns(arrB, MinColumn(arrB), MaxColumn(arrB));   
            PrintArray(arrB);
            }
        }
    }
