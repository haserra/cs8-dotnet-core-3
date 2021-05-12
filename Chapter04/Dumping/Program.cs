using System;
using SharpPad;
using System.Threading.Tasks;
using static System.Console;

namespace Dumping
{
    class Program
    {
        /// <summary>
        /// 4.2.6 - Customizing breakpoints
        /// </summary> 
        /// <param name="args"></param>

        static async Task Main(string[] args)
        {

            WriteLine("Chapter 04 - Writing, Debugging, and Testing Functions - Customizing breakpoints!");
            var complexObject = new
            {
                FirstName = "Petr",
                BirthDate = new DateTime(year: 1972, month: 12, day: 25),
                Friends = new string[] { "Amir", "Geoff", "Sal" }
            };

            WriteLine($"Dumping {nameof(complexObject)} to SharpPad.");

            await complexObject.Dump();
        }

        // 4.3.1 - Instrumenting with Debug and Trace (class Debug and Trace)





    }
}
