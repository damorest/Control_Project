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
            
            if(user.Length <= 100)
            
            {
                Console.WriteLine(user.Length);
            }
            
        }
    }
    
}
