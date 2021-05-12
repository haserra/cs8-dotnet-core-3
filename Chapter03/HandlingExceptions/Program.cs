using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Chapter 03 - Controlling Flow and Converting Types - Casting and converting between types - Handling exceptions when converting types");

            // 3.4.7 - Handling exceptions when converting types

            // Errors can occur when converting from one type to another.
            // When this happens, we say a runtime exception has been thrown.
            // Wrapping error-prone code in a try block

            WriteLine($"Before parsing");

            Write($"What is your age?");
            string input = ReadLine();

            try
            {
                int myAge = Convert.ToInt32(input);
                // or 
                int alsoMyAge = int.Parse(input);

                WriteLine($"Your age is {myAge}. But I can say that your age is also {alsoMyAge}. ");
            }
            catch (OverflowException ex2)
            {
                WriteLine("The age you entered is a valid number format, but it is either too large or too small for an Int32.");

            }
            catch (FormatException ex1)
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            catch (Exception ex)
            {
                WriteLine($"I could not read the value you entered: {ex.GetType()} - {ex.Message}. ");
            }

            WriteLine("After parsing.");

            // Now we know the type of exception that has ocurred: FormatException. So we can write a specific catch for that.
            // but leave the more general catch below! Because there might be other types of exceptions that can occur

            // 3.4.8 - Checking for overflow
            // 3.4.8.1 - Checking for overflow - Throwing overflow exceptions with the checked statement

            // The checked statement tells .NET to throw an exception when an overflow happens instead of allowing it to happen silently

        }
    }
}
