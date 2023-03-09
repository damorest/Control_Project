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
            
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i] == ' ')
                {
                    Console.WriteLine(i + 1);break;
                }
               
            }
            
        }
    }
    
}
