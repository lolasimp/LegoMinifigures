using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    class Pastor : Person, IGreeter
    {
        public void Greet(IGreetable person);
        {
            Console.Write($"Hey {person.Name}!");
        }
    }

    internal class Person
    {
    public string Name { get; set; }
    }
}
