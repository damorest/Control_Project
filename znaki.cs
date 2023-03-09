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
            int count = 0;
            
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i] == '.' || user[i] == ',' || user[i] == '!' || user[i] == ':' || user[i] == ';')
                {
                    count++;
                }
               
            }
            Console.WriteLine(count);
        }
    }
    
}
