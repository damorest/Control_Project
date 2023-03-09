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
            char ch;
            int symbol = Console.Read();
            int next = symbol + 32;
            int prev = symbol - 32;
            ch = Convert.ToChar(symbol);
           char chNext = Convert.ToChar(next);
           char chPrev = Convert.ToChar(prev);
            if (ch >= 65 && ch <= 90)
            {
                Console.WriteLine(chNext);
            }else if (ch >= 97 && ch <= 122)
            {
                Console.WriteLine(chPrev);
            }

       
        }
    }
    
}
