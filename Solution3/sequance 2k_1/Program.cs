﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequance_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);
            while (2 * num + 1 <= n)
            {
                num = num * 2 + 1;
                Console.WriteLine(num);
            }
        }
    }
}