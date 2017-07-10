﻿using System;
using static System.Console;

namespace FBNew
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
        }

        private static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    WriteLine("Fizz");
                else if (i % 5 == 0)
                    WriteLine("Buzz");
                else
                    WriteLine(i);
            }
        }
    }
}
