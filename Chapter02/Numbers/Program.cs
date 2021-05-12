using System;

namespace Numbers
{
    /// <summary>   
    /// Storing Numbers.   
    /// H.A.Serra 29/30 march 2021
    /// </summary>  
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positive whole number
            uint naturalNumber = 25;
            // integer means negative or positive whole number
            int integerNumber = -125;

            // float means single-precision  floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point
            double anotherRealNumber = 2.3; // double literal

            int oneMillion = 1_000_000;

            Console.WriteLine("Storing Numbers");

            // three variable that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            // checking if the three variables have th esame value
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            Console.WriteLine("Writing code to explore number sizes");

            // int type range 
            Console.WriteLine($" type int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");

            // double type range
            Console.WriteLine($" type double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");

            // decimal type range
            Console.WriteLine($" type decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            // Comparing double and decimal types            

            Console.WriteLine("Using doubles:");

            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equals 0.3");
            }

            // declaring numbers as decimal types instead, for accuracy guarantee

            Console.WriteLine("Using decimals:");

            decimal c = 0.01M; // M suffix means a decimal literal value
            decimal d = 0.02M;

            if (c + d == 0.03M)
            {
                Console.WriteLine($"{c} + {d} equals 0.03");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does not equals 0.03");
            }

            bool happy = true;
            bool sad = false;
        }
    }
}
