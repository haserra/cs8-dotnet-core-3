using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Bitwise and binary shift operators");

            int a = 10; // 0000 1010
            int b = 6; // 0000 0110

            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}"); // 2-bit column only
            WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
            WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns            

            // 0101 0000 left-shift a by three bit columns
            WriteLine($"a << 3 = {a << 3}");
            // multiply a by 8
            WriteLine($"a * 8 = {a * 8}");
            // 0000 0011 right-shift b by one bit column
            WriteLine($"b >> 1 = {b >> 1}");

            Console.WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Miscellaneous operators");

            // nameof, sizeof


            int age = 47;
            // How many operators in the following statement?
            string firstDigit = age.ToString();
            char _firstDigit = firstDigit[0];
            // There are four operators:
            // = is the assignment operator
            // . is the member access operator
            // () is the invocation operator
            // [] is the indexer access operator

            Console.WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Branching with the if statement");
        }
    }
}
