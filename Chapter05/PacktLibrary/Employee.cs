using System;
using static System.Console;

namespace Packt.Shared
{
    public class Employee : Person
    {
        public string employeeCode;
        public DateTime hireDate;

        // The correspondent auto implemented properties for the instance fields above
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public override void WriteToConsole()
        {
            WriteLine(format:
            "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
            arg0: Name,
            arg1: DateOfBirth,
            arg2: HireDate);
        }

        // Understanding polymorphism

        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}'s code is {EmployeeCode}";
        }




    }
}