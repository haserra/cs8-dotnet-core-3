using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practicing and exploring");
            Console.WriteLine($"Exercise 02");
            // defining types for the following "numbers"

            // A person's telephone
            string phoneNumber;

            // age
            int age;

            // salary;
            double salary;

            // book's ISBN

            // book's price

            // book's shipping weight

            // country's population

            // number of stars in the universe

            // number of employees in each of the small or medium businesses in the UK

            Console.WriteLine($" Outputting the number of bytes in memory that each of the following number types use:");

            // https://github.com/markjprice/cs8dotnetcore3/blob/master/Chapter02/Exercise02/Program.cs

            // Number types
            // sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal

            Console.WriteLine($"---------------------------------------------------------------------------");
            Console.WriteLine($"Type    Byte(s) of memory               Min                            Max");
            Console.WriteLine($"---------------------------------------------------------------------------");
            Console.WriteLine(format: "sbyte    {0, -4} {1,30} {2,30}", arg0: sizeof(sbyte), arg1: sbyte.MinValue, arg2: sbyte.MaxValue);
            Console.WriteLine(format: "byte     {0, -4} {1,30} {2,30}", arg0: sizeof(byte), arg1: byte.MinValue, arg2: byte.MaxValue);
            Console.WriteLine(format: "short    {0, -4} {1,30} {2,30}", arg0: sizeof(short), arg1: short.MinValue, arg2: short.MaxValue);
            Console.WriteLine(format: "ushort   {0, -4} {1,30} {2,30}", arg0: sizeof(ushort), arg1: ushort.MinValue, arg2: ushort.MaxValue);
            Console.WriteLine(format: "int      {0, -4} {1,30} {2,30}", arg0: sizeof(int), arg1: int.MinValue, arg2: int.MaxValue);
            Console.WriteLine(format: "uint     {0, -4} {1,30} {2,30}", arg0: sizeof(uint), arg1: uint.MinValue, arg2: uint.MaxValue);
            Console.WriteLine(format: "long     {0, -4} {1,30} {2,30}", arg0: sizeof(long), arg1: long.MinValue, arg2: long.MaxValue);
            Console.WriteLine(format: "ulong    {0, -4} {1,30} {2,30}", arg0: sizeof(ulong), arg1: ulong.MinValue, arg2: ulong.MaxValue);
            Console.WriteLine(format: "float    {0, -4} {1,30} {2,30}", arg0: sizeof(float), arg1: float.MinValue, arg2: float.MaxValue);
            Console.WriteLine(format: "double   {0, -4} {1,30} {2,30}", arg0: sizeof(double), arg1: double.MinValue, arg2: double.MaxValue);
            Console.WriteLine(format: "decimal  {0, -4} {1,30} {2,30}", arg0: sizeof(decimal), arg1: decimal.MinValue, arg2: decimal.MaxValue);
            Console.WriteLine($"---------------------------------------------------------------------------");

            /*

            Outputting the number of bytes in memory that each of the following number types use:
            ---------------------------------------------------------------------------
            Type     Byte(s) of memory               Min                            Max
            ---------------------------------------------------------------------------
            sbyte    1                              -128                            127
            byte     1                                 0                            255
            short    2                            -32768                          32767
            ushort   2                                 0                          65535
            int      4                       -2147483648                     2147483647
            uint     4                                 0                     4294967295
            long     8              -9223372036854775808            9223372036854775807
            ulong    8                                 0           18446744073709551615
            float    4                    -3,4028235E+38                  3,4028235E+38
            double   8          -1,7976931348623157E+308        1,7976931348623157E+308
            decimal  16   -79228162514264337593543950335  79228162514264337593543950335
            ---------------------------------------------------------------------------
            */
        }
    }
}
