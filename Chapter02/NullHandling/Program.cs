﻿#nullable enable

using System;

namespace NullHandling
{
    class Address
    {
        public string? Building; // Building of type string is nullable
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Null Handling!");
            int thisCannotBeNull = 4; // because is a value type
            // thisCannotBeNull = null; // 

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            //var address = new Adress();
            //address.Building = null;

            Address address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
        }
    }
}
