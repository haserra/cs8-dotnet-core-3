using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class ThingOfDefaults
    {
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;
        // Constructor

        /* 
        public ThingOfDefaults()
        {
            Population = default(int); // C# 2.0 and later
            When = default(DateTime);
            Name = default(string);
            People = default(List<Person>);
        }
        */
        public ThingOfDefaults()
        {
            Population = default; // C# 7.1 and later
            When = default;
            Name = default;
            People = default;
        }


    }
}