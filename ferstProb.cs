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

        static void Main(string[] args)
        {
            char start = Convert.ToChar(Console.Read());
            char finish = Convert.ToChar(Console.Read());
            char result;
            result = start;
            int prev = start;
            int next = finish;
            
            char chPrev = Convert.ToChar(result - 32);
            char chNext = Convert.ToChar(finish);
            if (start < finish)
            {

                for (int i = prev; i <= next; i++)
                {
                    Console.WriteLine($"{chPrev}{result}");

                    result++;
                    chPrev++;
                }
            }else if (start >  finish) 
            {
                prev = finish;
                next = start;
                for (int i = prev; i <= next; i++)
                {
                    Console.WriteLine($"{chPrev}{result}");

                    result++;
                    chPrev++;
                }
            }

        }
    }
    
}
