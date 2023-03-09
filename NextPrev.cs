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
            string user = Console.ReadLine();
            string[] element = Console.ReadLine().Trim().Split();
            byte n = byte.Parse(element[0]);
            byte m = byte.Parse(element[1]);
            string result = user.Remove(n - 1, (m - n) + 1);
            Console.WriteLine(result);
            /*int count = 0;
            
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i] == ' ')
                {
                    count++;
                }
                if (count == k)
                {
                    Console.WriteLine(i + 1); break;
                }

            }
            if (count < k)
            {
                Console.WriteLine(0);
            }*/
        
        }
    }
    
}
