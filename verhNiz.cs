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

            string user = Console.ReadLine();

            int count = 0;
            double sum = 0;

            if (user.Length <= n)
            {
                for (int i = 0; i < user.Length; i++)
                {
                    if (Convert.ToChar(user[i]) >= 48 && Convert.ToChar(user[i]) <= 57)
                    {
                        count++;
                        sum += Char.GetNumericValue(user[i]);

                    }
                    
                }
               
                Console.WriteLine(count);
               Console.WriteLine(sum);
            }
        }
    }
    
}
