using System;
using static System.Console;


namespace WritingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 04 - Writing, Debugging, and Testing Functions");

            // 4.1.1 - Writing Functions

            // 4.1.1.1 - Writing a times table function

            RunTimesTable();
            RunCalculateTax();
            RunCardinalToOrdinal();
            RunFactorial();
        }

        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} X { number} = {row * number}");
            }

        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                WriteLine($"Enter a number between 0 and 255:");
                isNumber = byte.TryParse(ReadLine(), out byte number);
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine($"You did not enter a valid number!");
                }
            }
            while (isNumber);
        }

        static void _RunTimesTable()
        {
            try
            {
                while (true)
                {
                    WriteLine($"Enter a number between 0 and 255:");
                    byte number = byte.Parse(ReadLine());
                    TimesTable(number);
                }
            }
            catch (Exception ex)
            {
                WriteLine($"You did not enter a valid number! {ex.Message}. Leaving now TimesTable function.");
            }
        }

        // 4.1.2 - Writing a times table function

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH": // Switzerland
                    rate = 0.08M;
                    break;
                case "DK": // Denmark
                case "NO": // Norway
                    rate = 0.25M;
                    break;
                case "GB": // United Kingdom
                case "FR": // France
                    rate = 0.2M;
                    break;
                case "HU": // Hungary
                    rate = 0.27M;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0M;
                    break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maryland
                case "VA": // Virginia
                    rate = 0.05M;
                    break;
                case "CA": // California
                    rate = 0.0825M;
                    break;
                default: // most US states
                    rate = 0.06M;
                    break;
            }

            return amount * rate;
        }

        static void RunCalculateTax()
        {
            WriteLine($"Please indicate an amount:");
            string amountInText = ReadLine();

            WriteLine($"Enter a two-letter digit code:");
            string region = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount) && region.Length == 2)
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount, or a valid region! Please try again.");
            }
        }

        /// <summary>
        /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
        /// 
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
        /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
        /// 
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    string numberAsText = number.ToString();
                    char lastDigit = numberAsText[numberAsText.Length - 1];
                    string suffix = string.Empty;
                    switch (lastDigit)
                    {
                        case '1':
                            suffix = "st";
                            break;
                        case '2':
                            suffix = "nd";
                            break;
                        case '3':
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }
                    return $"{number}{suffix}";
            }
        }

        static void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                WriteLine($"{CardinalToOrdinal(number)}, ");
            }
            WriteLine();
        }


        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static void RunFactorial()
        {
            bool isNumber;
            do
            {
                Write("Enter a number: ");
                isNumber = int.TryParse(ReadLine(), out int number);
                if (isNumber)
                {
                    WriteLine($"{number:N0}! = {Factorial(number):N0}");
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }
    }
}
