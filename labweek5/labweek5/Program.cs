﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line 1");
            goto line4;
        line2:
            Console.WriteLine("Line 2");

            goto line9;
            Console.WriteLine("Line 3");
        line4:
            Console.WriteLine("Line 4");
            Console.WriteLine("Line 5");
            goto line2;
            Console.WriteLine("Line 6");
            Console.WriteLine("Line 7");
            Console.WriteLine("Line 8");
        line9:

            Console.WriteLine("Line 9");
            goto end;
            Console.WriteLine("Line 10");
        end:;
        }
    }
}
