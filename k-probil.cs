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
            int next = symbol + 1;
            int prev = symbol - 1;
            ch = Convert.ToChar(symbol);
            char chNext = Convert.ToChar(next);
            char chPrev = Convert.ToChar(prev);
            Console.WriteLine($"The next char for \'{ch}\' ({symbol}) is \'{chNext}\' ({next}). ");
            Console.WriteLine($"The previous char for \'{ch}\' ({symbol}) is \'{chPrev}\' ({prev}). ");
        }
    }
    
}
