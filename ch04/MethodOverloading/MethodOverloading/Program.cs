﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Method Overloading *****\n");

            // Calls int version of Add()
            Console.WriteLine(Add(10, 10));

            // Calls long version of Add()
            Console.WriteLine(Add(900000000000, 900000000000));

            // Calls double version of Add()
            Console.WriteLine(Add(4.3, 4.4));

            Console.ReadLine();
        }

        // Overloaded Add() method.
        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static double Add(double x, double y)
        {
            return x + y;
        }

        private static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
