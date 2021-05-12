using System;
using static System.Console;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Chapter 04 - Writing, Debugging, and Testing Functions - Debugging during development");
            RunAdd();

        }

        static double Add(double a, double b)
        {
            return a + b; // deliberate bug! Now fixed!

        }

        static void RunAdd()
        {
            double a = 4.5; // or use var
            double b = 2.5;

            double answer = Add(a, b);
            WriteLine($"{a} + {b} = {answer}");
            ReadLine(); // wait for user to press ENTER

        }
    }
}
