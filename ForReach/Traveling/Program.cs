﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string destination = Console.ReadLine();
               
                if (destination == "End")
                {
                    break;
                }
                double requiredBudget = double.Parse(Console.ReadLine());
                double savings = 0;
                while (savings < requiredBudget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savings += money;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}