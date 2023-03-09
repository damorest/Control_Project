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


            int n = int.Parse(Console.ReadLine());
            string[] shifr = Console.ReadLine().Trim().Split();

            for(int i = 0; i < shifr.Length; i++)
            {
            char kod = char.Parse(shifr[i]);

                Console.Write(Convert.ToInt32(kod));

            }
            Console.WriteLine();


        }
    }
    
}
