using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 03 - Controlling Flow and Converting Types - Checking for overflow");

            // 3.4.8 - Checking for overflow
            // 3.4.8.1 - Checking for overflow - Throwing overflow exceptions with the checked statement

            // The checked statement tells .NET to throw an exception when an overflow happens instead of allowing it to happen silently

            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Initial value is: {x}.");
                    x++;
                    WriteLine($"After first incrementing x: {x}");
                    x++;
                    WriteLine($"After second incrementing x: {x}");
                    x++;
                    WriteLine($"After third incrementing x: {x}");
                }
            }
            catch (OverflowException ex)
            {
                WriteLine("The code overflowed but I caught the exception. Stay cool.");
            }

            // Disabling compiler overflow checks with the unchecked statement
            
            // TBD
        }
    }
}
