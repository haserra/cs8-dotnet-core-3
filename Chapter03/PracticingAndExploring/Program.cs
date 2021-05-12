using System;
using static System.Console;

namespace PracticingAndExploring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 03 - Controlling Flow and Converting Types - Casting and converting between types - Practicing And Exploring");

            // 3.5 - Practicing and exploring
            // 
            // 3.5.3 - Practicing and exploring - Practice loops and operators
            // The FizzBuzz game challenge



            try
            {
                WriteLine($"Please enter the upper limit, for which the FizzBuzz sequence should run:");
                string fizzBuzz = "FizzBuzz";
                string fizz = "Fizz";
                string buzz = "Buzz";
                int max = Convert.ToInt32(ReadLine());
                // or
                int _max = int.Parse(ReadLine());
                WriteLine($"Executing FizzBuzz game up to {max}.");

                for (int i = 1; i <= max; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        WriteLine($"{i,-5} - {fizzBuzz,10}");
                    }
                    else if (i % 3 == 0)
                    {
                        WriteLine($"{i,-5} - {fizz,12} ");

                    }
                    else if (i % 5 == 0)
                    {
                        WriteLine($"{i,-5} - {buzz,14}");
                    }
                    else
                    {
                        WriteLine($"{i,-5}");
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Ops! The maximum upper limit number you've entered is not a valid number format: {ex.Message}");
            }

            //

            // just a bit of mind blowing C#

            /* 
            int __max = 500;
            for (byte i = 0; i < __max; i++)
            {
                WriteLine(i);
            }
             */

            // Easely generate time tables!

            try
            {
                WriteLine($"Enter the Time Table you want to generate: 1 - 12");
                int timeTable = int.Parse(ReadLine());
                for (int j = 1; j <= timeTable; j++)
                {
                    WriteLine($"{j,5} X {timeTable,1} = {j * timeTable}");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"The time Table you have entered is not a valid number format: {ex.Message}");
            }
        }
    }
}
