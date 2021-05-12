using System;
using static System.Console;


namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Chapter 03 -- Controlling Flow and Converting Types");
            int a = 3;
            int b = a++; // this is a postfix operator as oposed to a prefix operator
            WriteLine($"a is {a} and b is {b}");
            b = a;
            WriteLine($"a is {a} and b is {b}");

            // IMPORTANT: never combine the use of ++ or -- operators combined with the = , in the same statement!

            int c = 3;
            c++;
            int d = c;
            WriteLine($"c is {c} and d is {d}");

            WriteLine("Chapter 03 -- Controlling Flow and Converting Types -- Binary arithmetic operators");
            WriteLine("\r\n");

            int e = 11;
            int f = 3;
            double g = 1.0;

            WriteLine($"Please enter an integer value for e: ");
            try
            {
                e = Int32.Parse(ReadLine());
            }
            catch (Exception ex)
            {
                WriteLine($"The number you've entered {e} is not an integer: {ex.Message}");
            }

            WriteLine($"Please enter an integer value for f: ");
            try
            {
                f = Int32.Parse(ReadLine());
            }
            catch (Exception ex)
            {
                WriteLine($"The number you've entered {f} is not an integer: {ex.Message}");
            }

            WriteLine($"Please enter a floating point number for g: ");
            try
            {
                g = Double.Parse(ReadLine());
            }
            catch (Exception ex)
            {
                WriteLine($"The number you've entered {g} is not an integer: {ex.Message}");
            }

            WriteLine($"e is {e}, f is {f}");
            WriteLine("\r\n");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");
            WriteLine($"g / f = {g / f}");

            WriteLine("Chapter 03 -- Controlling Flow and Converting Types -- Assignement operators");
            WriteLine("\r\n");

            int p = 6;
            p += 3; // equivalent to p = p + 3;
            p -= 3; // equivalent to p = p - 3;
            p *= 3; // equivalent to p = p * 3;
            p /= 3; // equivalent to p = p / 3;

        }
    }
}
