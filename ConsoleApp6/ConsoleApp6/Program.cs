﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi ime");
            string userName = Console.ReadLine();

            Console.WriteLine("vuvedi godini");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello {0} {1}", userName, userAge);
        }
    }
}
