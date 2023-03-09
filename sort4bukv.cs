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
            string userString = Console.ReadLine();

            char[] characters = new char[4];
            int count = 0;

            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] != ' ')
                {
                    characters[count] = userString[i];
                    count++;
                }
            }
            Array.Sort(characters);
            Console.WriteLine($"{characters[0]} {characters[1]} {characters[2]} {characters[3]}");

        }
    }
    }
