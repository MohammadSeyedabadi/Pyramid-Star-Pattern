﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_Star_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            String s = Console.ReadLine();
            int a = Convert.ToInt32(s);

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a - i; j++) Console.Write(" ");

                for (int j = 1; j <= 2 * i - 1; j++) Console.Write("*");

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
