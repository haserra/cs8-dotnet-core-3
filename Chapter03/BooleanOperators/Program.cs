using System;
using static System.Console;

namespace BooleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Boolean Operators - & , or |");
            WriteLine("\r\n");

            bool a = true;
            bool b = false;

            WriteLine($"AND | a | b ");
            WriteLine($"a | {a & a,-5} | {a & b,-5} ");
            WriteLine($"b | {b & a,-5} | {b & b,-5} ");
            WriteLine();
            WriteLine($"OR | a | b ");
            WriteLine($"a | {a | a,-5} | {a | b,-5} ");
            WriteLine($"b | {b | a,-5} | {b | b,-5} ");
            WriteLine();
            WriteLine($"XOR | a | b ");
            WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");

            WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Conditional Logic Operators: &&, or ||");
            WriteLine("\r\n");

            WriteLine($"a & DoSomeStuff() = {a & DoSomeStuff()}");
            WriteLine($"b & DoSomeStuff() = {b & DoSomeStuff()}");

            WriteLine("\r\n");

            WriteLine($"a && DoSomeStuff() = {a && DoSomeStuff()}");
            WriteLine($"b && DoSomeStuff() = {b && DoSomeStuff()}");
        }

        private static bool DoSomeStuff()
        {
            WriteLine($"I am just wasting CPU clock cycles.");
            return true;
        }

    }
}
