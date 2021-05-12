using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Casting and converting between types ");

            // 3.4 - CASTING AND CONVERTING BETWEEN TYPES

            // 3.4.1 - CASTING NUMBERS IMPLICITLY AND EXPLICITLY            
            // converting from one type to another is also known as casting, and it can be implicit (safe) or explicit (not safe).

            int a = 10;
            double b = a; // an int can be safely cast into a double
            WriteLine(b);

            double c = 9.8;
            int d = (int)c; // compiler gives an error for this line
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"1. e is {e:N0} and f is {f:N0}.");

            e = long.MaxValue;
            f = (int)e;
            WriteLine($"2. e is {e:N0} and f is {f:N0}.");

            e = 5_000_000_000;
            f = (int)e; // cast to 32 bit signed number ! 
            WriteLine($"2. e is {e:N0} and f is {f:N0}.");


            // 3.4.2 - Converting with the System.Convert type

            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            // 3.4.3 - Rounding numbers


            // 3.4.4 - Converting from any type to a string
            // Because it's so useful to have any type converted to string, all types have the method ToString, because they inherit it from System.Object class

            int number = 12;
            object someInteger = 14;
            WriteLine($"number {number:N0}");
            // converting it to a string
            WriteLine($"number {number.ToString()}");

            bool someBoolean = true;
            WriteLine($"someBoolean value is {someBoolean.ToString()}");

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            // 3.4.5 - Converting from a binary object to a string
            // Instead of dealing with the raw format file of an Image or Video, it is safer if we convert these files into s string of characters.
            // this is called the Base64 encoding

            // The Convert type (class)  has a pair of methods: ToBase64String and FromBase64String.

            // allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            Random rnd = new Random(); // create a random number generator

            // populate the array with random bytes
            rnd.NextBytes(binaryObject);
            var someRandom = rnd.Next();

            WriteLine("Binary Object as bytes");

            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X} ");
            }
            WriteLine($" Now converting the array to a Base64 string and output as text");
            WriteLine("\r\n");

            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64 is: {encoded}");

            foreach (Byte item in binaryObject)
            {
                WriteLine($"{item:X}");
            }

            // 3.4.6 - Parsing from strings to numbers or dates and times
            // The opposite of ToString is Parse. Only a few types have a Parse method, including all the number types and DateTime

            int myAge = int.Parse("53");
            DateTime myBirthDay = DateTime.Parse("11 December 1967");

            WriteLine($"I was born {myAge,-10} years ago.");
            WriteLine($"My birthday is {myBirthDay,-10}");
            WriteLine($"My birthday is {myBirthDay,-10:D}");

            WriteLine($"What happens when I try to parse a string of a string?");

            try
            {
                int tryCount = int.Parse("abc");
                WriteLine(tryCount);
            }
            catch (Exception ex)
            {
                WriteLine($"Could not convert 'abc'  to an integer: {ex.Message}");
            }

            // 

            // 3.4.7 - Avoiding exceptions using the TryParse method

            Write("How many eggs are there? ");
            int count;
            string inputData = ReadLine();

            if (int.TryParse(inputData, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine($"I could not parse the input: {inputData}.");
            }
        }
    }
}
